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

namespace Clima
{
    public partial class Form1 : Form
    {
        private static UserService _service;

        List<string> cities = new List<string>();
        User active_user;
        List<string> user_cities = new List<string>();

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
        }

        private void LoadCities()
        {
            IProxyCountry proxy = new ProxyCountry();
            var countries = proxy.Countries();

            foreach (var i in countries)
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
                MessageBox.Show("Usuario o contraseña incorrectos.", "OK");
            else
                MessageBox.Show($"{active_user.Email}", "OK");

            user_login.Text = "";
            pass_login.Text = "";
            encrypt_login.SelectedIndex = 0;

            if(active_user != null)
            {
                panel2.Visible = false;
                panel1.Visible = false;

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
            panel_add.Visible = false;

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            panel_add.Visible = true;
        }
    }
}
