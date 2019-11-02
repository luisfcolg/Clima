using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clima.Models;
using Clima.Services;
using Clima.DataAccess;
using System.Configuration;
using Clima.Strategy;
using Clima.PasswordHelper;
using Clima.Adapters;

namespace Clima
{
    public partial class Form1 : Form
    {
        private static UserService _service;

        List<string> cities = new List<string>();
        User active_user;
        List<string> user_cities = new List<string>();
        List<DisplayCity> datagrid_cities = new List<DisplayCity>();

        public Form1()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ToString();
            _service = new UserService(connectionString);

            LoadCities();

            InitializeComponent();

            encrypt_reg.SelectedIndex = 0;
            encrypt_login.SelectedIndex = 0;

            BindingSource source = new BindingSource();
            source.DataSource = cities;
            cities_combo.DataSource = source;
            cities_combo.SelectedIndex = 0;

            source = new BindingSource();
            source.DataSource = datagrid_cities;
            dataGridView1.DataSource = source;

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.HeaderText = "Delete";
            col.Name = "delete_city";
            col.Text = "Delete";
            col.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(col);

            dataGridView1.Columns["Name"].ReadOnly = true;
            dataGridView1.Columns["Temp"].ReadOnly = true;
            dataGridView1.Columns["TempMax"].ReadOnly = true;
            dataGridView1.Columns["TempMin"].ReadOnly = true;
        }

        private void LoadCities()
        {
            IProxyCountry proxy = new ProxyCountry();
            var countries = proxy.Countries();

            foreach (var i in countries)
                if(i.capital != "")
                    cities.Add(i.capital);
        }

        private List<string> GetUserCities(User u)
        {
            List<string> c = new List<string>(u.Cities.Split('|'));
            return c;
        }

        // Login click
        private void button3_Click(object sender, EventArgs e)
        {
            PasswordBuilder pass;
            if (encrypt_login.SelectedIndex == 0)
                pass = new SHA1Builder(pass_login.Text);
            else
                pass = new SHA256Builder(pass_login.Text);

            pass.GenerateBytes();
            pass.GenerateHashBytes();
            pass.GenerateHashString();

            active_user = _service.GetUser(user_login.Text, pass.GetPassword().HashString);

            if(active_user == null)
                MessageBox.Show("Wrong user or password.", "OK");
            else
                MessageBox.Show("Successful login.", "OK");

            user_login.Text = "";
            pass_login.Text = "";
            encrypt_login.SelectedIndex = 0;

            if(active_user != null)
            {
                panel2.Visible = false;
                panel1.Visible = false;

                user_main.Text = active_user.Username;
                email_main.Text = active_user.Email;

                if(active_user.Cities != "")
                    user_cities = GetUserCities(active_user);
            }
        }

        // Register link click
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = false;
        }

        // Register click
        private void button1_Click(object sender, EventArgs e)
        {
            if(user_reg.Text == "" | email_reg.Text == "" | pass_reg.Text == "")
            {
                MessageBox.Show("Please, complete all the fealds.", "OK");
                user_reg.Text = "";
                email_reg.Text = "";
                pass_reg.Text = "";
                encrypt_reg.SelectedIndex = 0;
                return;
            }

            // Validate email
            string m = email_reg.Text;

            var mail = new ValidateMailClass(new ValidateMailAt(), m);
            if(mail.Validate())
            {
                mail = new ValidateMailClass(new ValidateMailDomain(), m);
                if(!mail.Validate())
                {
                    MessageBox.Show("Wrong email adress.", "OK");
                    user_reg.Text = "";
                    email_reg.Text = "";
                    pass_reg.Text = "";
                    encrypt_reg.SelectedIndex = 0;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Wrong email adress.", "OK");
                user_reg.Text = "";
                email_reg.Text = "";
                pass_reg.Text = "";
                encrypt_reg.SelectedIndex = 0;
                return;
            }

            // Validate username
            if (_service.VerifyUser(user_reg.Text, email_reg.Text))
            {
                MessageBox.Show("Username or email are already taken.", "OK");
                user_reg.Text = "";
                email_reg.Text = "";
                pass_reg.Text = "";
                encrypt_reg.SelectedIndex = 0;
                return;
            }

            // Password encryption
            PasswordBuilder pass;
            if (encrypt_reg.SelectedIndex == 0)
                pass = new SHA1Builder(pass_reg.Text);
            else
                pass = new SHA256Builder(pass_reg.Text);

            pass.GenerateBytes();
            pass.GenerateHashBytes();
            pass.GenerateHashString();

            User u = new User { Username = user_reg.Text, Email = email_reg.Text, Password=pass.GetPassword().HashString, Cities="", Passtype=encrypt_reg.SelectedIndex};

            string result = _service.AddUser(u);

            MessageBox.Show(result, "OK");

            user_reg.Text = "";
            email_reg.Text = "";
            pass_reg.Text = "";
            encrypt_reg.SelectedIndex = 0;

            panel1.Visible = true;
        }

        // Add city
        private void addcity_button_Click(object sender, EventArgs e)
        {
            string c = cities[cities_combo.SelectedIndex];

            if(!user_cities.Contains(c))
            {
                user_cities.Add(c);
            }
            else
            {
                MessageBox.Show("The city is already on favourites.", "OK");
            }
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            IProxyWeather proxy = new ProxyWeather();
            TotalCDegrees degrees = new TotalCDegrees();
            FDegreesConverter converter = new FDegreesConverter(degrees);

            dataGridView1.Rows.Clear();

            foreach(var i in user_cities)
            {
                var weather = proxy.Weather(i);
                converter.ConvertFDegreees(weather.main.temp);
                double temp = converter.GetCDegrees();
                converter.ConvertFDegreees(weather.main.temp_max);
                double temp_max = converter.GetCDegrees();
                converter.ConvertFDegreees(weather.main.temp_min);
                double temp_min = converter.GetCDegrees();
                DisplayCity c = new DisplayCity { Name = i, Temp = temp, TempMax = temp_max, TempMin = temp_min };
                datagrid_cities.Add(c);
            }

            BindingSource source = new BindingSource();
            source.DataSource = datagrid_cities;
            dataGridView1.DataSource = source;

            panel_add.Visible = false;
            panel4.Visible = true; 
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            panel_add.Visible = true;
            panel4.Visible = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 1 | dataGridView1.CurrentCell.ColumnIndex == 2 | dataGridView1.CurrentCell.ColumnIndex == 3 | dataGridView1.CurrentCell.ColumnIndex == 4)
                return;

            user_cities.RemoveAt(dataGridView1.CurrentCell.RowIndex);

            IProxyWeather proxy = new ProxyWeather();
            TotalCDegrees degrees = new TotalCDegrees();
            FDegreesConverter converter = new FDegreesConverter(degrees);

            dataGridView1.Rows.Clear();

            foreach (var i in user_cities)
            {
                var weather = proxy.Weather(i);
                converter.ConvertFDegreees(weather.main.temp);
                double temp = converter.GetCDegrees();
                converter.ConvertFDegreees(weather.main.temp_max);
                double temp_max = converter.GetCDegrees();
                converter.ConvertFDegreees(weather.main.temp_min);
                double temp_min = converter.GetCDegrees();
                DisplayCity c = new DisplayCity { Name = i, Temp = temp, TempMax = temp_max, TempMin = temp_min };
                datagrid_cities.Add(c);
            }

            BindingSource source = new BindingSource();
            source.DataSource = datagrid_cities;
            dataGridView1.DataSource = source;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string city = user_cities[dataGridView1.CurrentCell.RowIndex];

            selected_city.Text = city;

            IProxyWeather proxy = new ProxyWeather();
            TotalCDegrees degrees = new TotalCDegrees();
            FDegreesConverter converter = new FDegreesConverter(degrees);

            var forecast = proxy.Forecast(city);

            converter.ConvertFDegreees(forecast.list[0].main.temp);
            double temp = converter.GetCDegrees();
            today_w.Text = ""+temp;
            converter.ConvertFDegreees(forecast.list[1].main.temp);
            temp = converter.GetCDegrees();
            day1_w.Text = "" + temp;
            converter.ConvertFDegreees(forecast.list[2].main.temp);
            temp = converter.GetCDegrees();
            day2_w.Text = "" + temp;
            converter.ConvertFDegreees(forecast.list[3].main.temp);
            temp = converter.GetCDegrees();
            day3_w.Text = "" + temp;
            converter.ConvertFDegreees(forecast.list[4].main.temp);
            temp = converter.GetCDegrees();
            day4_w.Text = "" + temp;
            converter.ConvertFDegreees(forecast.list[5].main.temp);
            temp = converter.GetCDegrees();
            day5_w.Text = "" + temp;

            panel4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cities = "";

            foreach(var i in user_cities)
            {
                if (cities == "")
                    cities += i;
                else
                    cities += "|" + i;
            }

            active_user.Cities = cities;

            string s =_service.Update(active_user);

            panel3.Visible = true;
            panel_menu.Visible = true;
            panel5.Visible = true;
            panel4.Visible = true;
            panel_add.Visible = true;
            panel2.Visible = true;
            panel1.Visible = true;

            MessageBox.Show(s, "OK");
        }
    }
}
