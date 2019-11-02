using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Clima.Models;

namespace Clima.DataAccess
{
    class UserDataServiceSingleton
    {
        private readonly SQLClient _client;
        private static UserDataServiceSingleton _instance;

        private UserDataServiceSingleton(string connectionString)
        {
            _client = new SQLClient(connectionString);
        }

        public static UserDataServiceSingleton GetInstance(string connectionString)
        {
            if (_instance == null)
                _instance = new UserDataServiceSingleton(connectionString);

            return _instance;
        }

        public bool AddUser(User user)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Connection,
                        CommandText = "adduser",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@username", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.Username
                    };

                    var par2 = new SqlParameter("@email", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.Email
                    };

                    var par3 = new SqlParameter("@pass", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.Password
                    };

                    var par4 = new SqlParameter("@cities", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.Cities
                    };

                    var par5 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par4);
                    command.Parameters.Add(par5);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());
                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }

        public User GetUser(string username, string password)
        {
            var result = new User();
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Connection,
                        CommandText = "getuser",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@username", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = username
                    };

                    var par2 = new SqlParameter("@pass", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        Value = password
                    };

                    var par3 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);

                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var user = new User
                        {
                            Id = Convert.ToInt32(dataReader["iduser"].ToString()),
                            Username = dataReader["username"].ToString(),
                            Email = dataReader["email"].ToString(),
                            Password = dataReader["pass"].ToString(),
                            Cities = dataReader["cities"].ToString()
                        };
                        result = user;
                    }
                }
            }
            catch
            {
                // ignored
            }
            finally
            {
                _client.Close();
            }

            return result;
        }

        public bool UpdateUser(User user)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Connection,
                        CommandText = "updateuser",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@username", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.Username
                    };

                    var par2 = new SqlParameter("@email", SqlDbType.DateTime)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.Email
                    };

                    var par3 = new SqlParameter("@pass", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.Password
                    };

                    var par4 = new SqlParameter("@cities", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = user.Cities
                    };

                    var par5 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par4);
                    command.Parameters.Add(par5);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());
                }
            }
            catch
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }
    }
}
