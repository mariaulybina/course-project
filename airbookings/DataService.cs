using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Drawing;

namespace airbookings
{
    class DataService
    {
        public static readonly string connectionString = "server=localhost;user=root;password=123456;database=airbookings;port=3306;charset=utf8;";//Строка подключения к MySQL

        //--------------------------------------------------------АВТОРИЗАЦИЯ-------------------------------------------------------------------//

        public static void getUserInf(ref User user)//метод для получения типа, email'а и имени пользователя
        {
            user.userType = null;//устанавливаем пустое значение типа

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем  соединение

                    MySqlCommand command = new MySqlCommand("login_password", connection);//объявляем команду
                    command.CommandType = System.Data.CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter loginParameter = new MySqlParameter//задаем первый параметр ХП - логин
                    {
                        ParameterName = "log",//указываем имя параметра
                        Value = user.login//передаем значение
                    };
                    command.Parameters.Add(loginParameter);//добавляем параметр 

                    MySqlParameter passwordParameter = new MySqlParameter//Задаем второй параметр ХП - пароль
                    {
                        ParameterName = "pass",//указываем имя параметра
                        Value = user.password//передаем значение
                    };
                    command.Parameters.Add(passwordParameter);//добавляем параметр 

                    var reader = command.ExecuteReader();//создаем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            user.sex = reader.GetString(0);//пол пользователя
                            user.userType = reader.GetString(3);//Тип пользователя
                            user.email = reader.GetString(4);//в user.email пишем email
                            user.name = reader.GetString(5);//в user.name пишем имя
                            user.citizenship = reader.GetString(6);//в user.citixenship пишем гражданство
                            user.city = reader.GetString(7);//в user.citixenship пишем город
                        }
                    }
                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }

        public static Passenger GetPassengerByEmail(string email)//Метод для получения пассажира по email'у
        {
            DataSet data = new DataSet();//Создаем объект DataSet

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("get_passenger_by_email", connection);//объявляем команду
                command.CommandType = System.Data.CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - email
                {
                    ParameterName = "email_",//указываем имя параметра
                    MySqlDbType = MySqlDbType.VarChar,//задаем тип параметра
                    Value = email//передаем значение
                };
                //добавляем параметр 
                command.Parameters.Add(parameter);
                //объявляем объект MySQLDataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;//выбираем команду
                try
                {
                    connection.Open();//открываем соединение
                    adapter.Fill(data);//заполняем adapter
                    connection.Close();//закрывем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
            if (data.Tables[0].Rows.Count == 0)//Если в DataTabe ничего нет
            {
                return null;//возвращаем пустое значение
            }
            else//иначе
            {

                Passenger passenger = new Passenger();//объявляем экземпляр класса Passenger
                passenger.id = Convert.ToInt32(data.Tables[0].Rows[0]["id"]);//заполняем поле id
                passenger.sex = data.Tables[0].Rows[0]["Пол"].ToString();//заполняем поле пол
                passenger.firstname = data.Tables[0].Rows[0]["Имя"].ToString();//заполняем поле первое имя
                passenger.midname = data.Tables[0].Rows[0]["Отчество"].ToString(); ;//заполняем поле второе имя
                passenger.lastname = data.Tables[0].Rows[0]["Фамилия"].ToString(); ;//заполняем поле последнее имя
                passenger.birthday = DateTime.Parse(data.Tables[0].Rows[0]["ДатаРождения"].ToString());//дата рождения
                passenger.citizen = data.Tables[0].Rows[0]["Гражданство"].ToString();//гражданство
                passenger.passport = data.Tables[0].Rows[0]["Паспорт"].ToString();//паспорт
                passenger.email = data.Tables[0].Rows[0]["email"].ToString();//email
                return passenger;//метод возвращает экземпляр класса Passenger passenger
            }
        }
        //--------------------------------------------------------РЕГИСТРАЦИЯ-------------------------------------------------------------------//
        public static bool IsUserRegistered(string login)//Метод для проверки уникальности логина
        {
            bool res = false;
            DataSet data = new DataSet();//Создаем объект DataSet

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("is_user_registered", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура
                    MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - login
                    {
                        ParameterName = "login_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = login//передаем значение
                    };

                    command.Parameters.Add(parameter); //добавляем параметр
                    connection.Open();//открываем соединение
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;//выбираем команду
                    adapter.Fill(data);//заполняем adapter
                    if (data.Tables[0].Rows.Count == 0)//Если в DataTabe ничего нет
                    {
                        res = false;//возвращаем пустое значение
                    }
                    else res = true;
                    connection.Close();
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
            return res;
        }

        public static List<string> GetCountry()//метод для заполнения citizenshipComboBox
        {
            List<string> countries = new List<string>();//создаем строковый список стран

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение

                    MySqlCommand command = new MySqlCommand("get_countries", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    var reader = command.ExecuteReader();//Объявляем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(1))//Если поле Название не пустое
                            {
                                countries.Add(reader.GetString(1));//добавляем значение в список стран
                            }
                        }
                    }
                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
                return countries;//возвращаем список
            }
        }

        public static bool CheckCity(string city)//метод для проверки существования определенного города
        {
            bool res = false;// результат отрицательный

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение

                    MySqlCommand command = new MySqlCommand("check_city", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура
                    MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - city
                    {
                        ParameterName = "city_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = city//передаем значение
                    };
                    command.Parameters.Add(parameter); //добавляем параметр
                    var reader = command.ExecuteReader();//Объявляем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        res = true;// результат положительный
                    }
                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
                return res;//возвращаем результат проверки
            }
        }
        public static bool CheckRegistrationData(string login, string password, string email, string name, object citizenship, string city)//метод для проверки данных введенных при регистрации
        {
            bool res = false;
            try
            {
                if ((login.Trim().Length == 0) ||
               (password.Trim().Length == 0) ||
               (email.Trim().Length == 0) ||
               (name.Trim().Length == 0) ||
               (citizenship == null) ||
               (city.Trim().Length == 0))//Если одно или несколько полей пусты
                {
                    MessageBox.Show("Необходимо заполнить все поля", "Предупреждение");//Выводим предупреждение
                    return res = false;
                }
                else
                {
                    if (IsUserRegistered(login))//Если существует пользователь с введенным логином
                    {
                        MessageBox.Show("Введенный логин занят другим пользователем", "Предупреждение");//Выводим предупреждение
                        return res = false;
                    }
                    else

                    {
                        if (!CheckCity(city))//Если введенного города не существует
                        {
                            MessageBox.Show("Неизвестный город, попробуйте ввести другой", "Предупреждение");//Выводим предупреждение
                            return res = false;
                        }
                        else
                        {
                            if (password.Length < 6)
                            {
                                MessageBox.Show("Пароль должен содержать не менее 6 символов", "Предупреждение");//выводим сообщение об ошибке
                                return res = false;
                            }
                            else
                            {
                                for (int i = 0; i < 10; i++)//для цифр от 0 до 9
                                {
                                    if (login[0].ToString() == i.ToString())//Если первый символ логина - цифра
                                    {
                                        MessageBox.Show("Логин не должен начинаться с цифры", "Предупреждение");//выводим сообщение об ошибке
                                        return res = false;
                                    }
                                    else
                                    {
                                        if (!Regex.IsMatch(email, @"^\w+@gmail.com$"))
                                        {
                                            MessageBox.Show("Почта не соответствует формату \n\rФормат почты: somemail@gmail.com", "Сообщение", MessageBoxButtons.OK);//выводим сообщение об ошибке
                                            return res = false;
                                        }
                                        else { res = true; }//результат - положительный
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)//ловим исключение
            {
                MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
            }
            return res;
        }

        public static string FindCountryCode(string country)//метод для нахождения кода страны при добавлении пользователя в систему
        {
            string countrycode = "";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем  соединение
                    MySqlCommand command = new MySqlCommand("get_country_code", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - country
                    {
                        ParameterName = "country_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = country//передаем значение
                    };
                    command.Parameters.Add(parameter); //добавляем параметр
                    var reader = command.ExecuteReader();//создаем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))//Если поле код не пустое
                            {
                                countrycode = reader.GetString(0);//добавляем значение в список кодов
                            }
                        }
                    }

                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
                return countrycode;//возвращаем код города
            }
        }
        public static int FindCityCode(string city)//метод для нахождения кода страны при добавлении пользователя в систему
        {
            int citycode = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение
                    MySqlCommand command = new MySqlCommand("get_city_code", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - city
                    {
                        ParameterName = "city_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = city//передаем значение
                    };
                    command.Parameters.Add(parameter); //добавляем параметр

                    var reader = command.ExecuteReader();//Объявляем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))//Если поле код не пустое
                            {
                                citycode = Convert.ToInt32(reader.GetString(0));//добавляем значение в список кодов
                            }
                        }
                    }
                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
                return citycode;//возвращаем код города
            }
        }
        public static void RegistrationUser(string login, string password, string email, string name, string country, string city, string sex)//метод для регистрации пользователя в системе
        {
            //MessageBox.Show(login+"', '"+getHash(password)+"', '"+email+"', '"+name+"', '"+FindCountryCode(country)+"', '"+FindCityCode(city));

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("registration", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter sexParameter = new MySqlParameter//задаем параметр ХП - sex
                    {
                        ParameterName = "sex_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = sex//передаем значение
                    };
                    command.Parameters.Add(sexParameter); //добавляем параметр
                    MySqlParameter loginParameter = new MySqlParameter//задаем параметр ХП - login
                    {
                        ParameterName = "login_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = login//передаем значение
                    };
                    command.Parameters.Add(loginParameter); //добавляем параметр

                    MySqlParameter passwordParameter = new MySqlParameter//задаем параметр ХП - passwoed
                    {
                        ParameterName = "password_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = getHash(password)//передаем значение
                    };
                    command.Parameters.Add(passwordParameter); //добавляем параметр

                    MySqlParameter usertypeParameter = new MySqlParameter//задаем параметр ХП - usertype
                    {
                        ParameterName = "usertype_",//указываем имя параметра
                        Value = 3//передаем значение
                    };
                    command.Parameters.Add(usertypeParameter); //добавляем параметр

                    MySqlParameter emailParameter = new MySqlParameter//задаем параметр ХП - email
                    {
                        ParameterName = "email_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = email//передаем значение
                    };
                    command.Parameters.Add(emailParameter); //добавляем параметр

                    MySqlParameter fullnameParameter = new MySqlParameter//задаем параметр ХП - fullname
                    {
                        ParameterName = "fullname_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = name//передаем значение
                    };
                    command.Parameters.Add(fullnameParameter); //добавляем параметр

                    MySqlParameter citizenshipParameter = new MySqlParameter//задаем параметр ХП - citizenship
                    {
                        ParameterName = "citizenship_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = FindCountryCode(country)//передаем значение
                    };
                    command.Parameters.Add(citizenshipParameter); //добавляем параметр

                    MySqlParameter cityParameter = new MySqlParameter//задаем параметр ХП - city
                    {
                        ParameterName = "city_",//указываем имя параметра
                        Value = FindCityCode(city)//передаем значение
                    };
                    command.Parameters.Add(cityParameter); //добавляем параметр

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }
        public static void CleanAllTextBoxesIn(Control parent)//метод для очистки формы Регистрация
        {
            foreach (Control c in parent.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;
            }
        }
        public static string getHash(string input)//метод для получения хеша
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

        //-------------------------------------------------------------МОЙ ПРОФИЛЬ-------------------------------------------------------------------//

        public static bool CheckUpdateData(string name, object citizenship, string city)//метод для проверки данных введенных при изменении профиля
        {
            bool res = false;
            try
            {
                if ((name.Trim().Length == 0) ||
               (citizenship == null) ||
               (city.Trim().Length == 0))//Если одно или несколько полей пусты
                {
                    MessageBox.Show("Необходимо заполнить все поля", "Предупреждение");//Выводим предупреждение
                    return res = false;
                }
                else
                {
                    if (!CheckCity(city))//Если введенного города не существует
                    {
                        MessageBox.Show("Неизвестный город, попробуйте ввести другой", "Предупреждение");//Выводим предупреждение
                        return res = false;
                    }
                    else { res = true; }//результат - положительный
                }
            }
            catch (Exception ex)//ловим исключение
            {
                MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
            }
            return res;
        }

        public static void UpdateMyProfile(string login, string sex, string name, string citizenship, string city)//метод для обновления профиля пользователя
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    //MessageBox.Show(login+"', '"+sex+"', '"+name+"', '"+FindCountryCode(citizenship)+"', '"+FindCityCode(city));
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("myprofile_update", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter loginParameter = new MySqlParameter//задаем параметр ХП - login
                    {
                        ParameterName = "login_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = login//передаем значение
                    };
                    command.Parameters.Add(loginParameter); //добавляем параметр
                    MySqlParameter sexParameter = new MySqlParameter//задаем параметр ХП - sex
                    {
                        ParameterName = "sex_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = sex//передаем значение
                    };
                    command.Parameters.Add(sexParameter); //добавляем параметр

                    MySqlParameter fullnameParameter = new MySqlParameter//задаем параметр ХП - fullname
                    {
                        ParameterName = "fullname_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = name//передаем значение
                    };
                    command.Parameters.Add(fullnameParameter); //добавляем параметр

                    MySqlParameter citizenshipParameter = new MySqlParameter//задаем параметр ХП - citizenship
                    {
                        ParameterName = "citizenship_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = FindCountryCode(citizenship)//передаем значение
                    };
                    command.Parameters.Add(citizenshipParameter); //добавляем параметр

                    MySqlParameter cityParameter = new MySqlParameter//задаем параметр ХП - city
                    {
                        ParameterName = "city_",//указываем имя параметра
                        Value = FindCityCode(city)//передаем значение
                    };
                    command.Parameters.Add(cityParameter); //добавляем параметр

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }
        //-------------------------------------------------------------------СМЕНА ПАРОЛЯ-------------------------------------------------------------------//
        public static bool checkPasswordChangeData(string currentPassword, string newPassword, string repeatNewPassword)//метод для проверки данных введенных на форме смены пароля
        {
            bool res = false;
            try
            {
                if ((currentPassword.Trim().Length == 0) || (newPassword.Trim().Length == 0) || (repeatNewPassword.Trim().Length == 0))
                {
                    MessageBox.Show("Необходимо заполнить все поля", "Предупреждение");//Выводим предупреждение
                    return res = false;
                }
                else if (newPassword != repeatNewPassword)
                {
                    MessageBox.Show("Новый пароль не соответствует повторному вводу", "Предупреждение");//Выводим предупреждение
                    return res = false;
                }
                else if (newPassword.Length < 6)
                {
                    MessageBox.Show("Пароль должен содержать не менее 6 символов", "Предупреждение");//Выводим предупреждение
                    return res = false;
                }
                else
                {
                    return res = true;
                }
            }
            catch (Exception ex)//ловим исключение
            {
                MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
            }
            return res;
        }

        public static void updatePassword(string login, string newPassword)//метод для изменения пароля пользователя
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("password_update", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter loginParameter = new MySqlParameter//задаем параметр ХП - login
                    {
                        ParameterName = "login_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = login//передаем значение
                    };
                    command.Parameters.Add(loginParameter); //добавляем параметр

                    MySqlParameter passwordParameter = new MySqlParameter//задаем параметр ХП - password
                    {
                        ParameterName = "password_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = getHash(newPassword)//передаем значение
                    };
                    command.Parameters.Add(passwordParameter); //добавляем параметр

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }

        public static void DeleteMyprofile(string login)//метод для удаления учетной записи
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Вы уверены? Учетная запись будет удалена безвозвратно", "Предупреждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand("delete_myprofile", connection);//объявляем команду
                        command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                        MySqlParameter loginParameter = new MySqlParameter//задаем параметр ХП - login
                        {
                            ParameterName = "login_",//указываем имя параметра
                            MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                            Value = login//передаем значение
                        };
                        command.Parameters.Add(loginParameter); //добавляем параметр

                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }
        //--------------------------------------------------------------------РЕЙСЫ------------------------------------------------------------------------//
        public static List<string> GetCity()//метод для заполнения departureComboBox и arrivalComboBox
        {
            List<string> cities = new List<string>();//создаем строковый список стран

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение

                    MySqlCommand command = new MySqlCommand("get_cities", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    var reader = command.ExecuteReader();//Объявляем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))//Если поле Название не пустое
                            {
                                cities.Add(reader.GetString(0));//добавляем значение в список стран
                            }
                        }
                    }
                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
                return cities;//возвращаем список
            }
        }
        public static void GetFlightsInfo(DataGridView dataGrid)
        {
            DataTable flightData = new DataTable();//Создаем объект DataTable
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение

                    MySqlCommand command = new MySqlCommand("get_flights_info", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(flightData);
                    connection.Close();//закрываем соединение
                    if (flightData.Rows.Count == 0)//Если в DataTabe ничего нет
                    {
                        MessageBox.Show("Нет доступных рейсов");
                    }
                    else
                    {
                        dataGrid.DataSource = flightData;
                    }    
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
            }
        }

        public static void GetFilteredFlights(DataGridView dataGrid, object departure, object arrival, DateTime firstDepartureDate, DateTime secondDepartureDate)//метод для получения отфильтрованного списка полетов
        {
            DataTable flightData = new DataTable();//Создаем объект DataTable
            string sql = "";//строковая переменная для хранения sql-запроса

            if (departure != null && arrival != null && departure.ToString()==arrival.ToString())//если город отправления и город прибытия совпадают
                MessageBox.Show("Город отправления и прибытия не должны совпадать");

            if ((firstDepartureDate.Date < System.DateTime.Now.Date) || (secondDepartureDate.Date < System.DateTime.Now.Date))//если одна или обе даты предшествуют текущей
            {
                MessageBox.Show("Невозможно указывать дату предшествующую текущей","Предупреждение");//выводим предупреждение
                return;
            }

            if (firstDepartureDate.Date > secondDepartureDate.Date)//если вторая дата предшествует первой
            {
                MessageBox.Show("Вторая дата не должна предшествовать первой", "Предупреждение");//выводим предупреждение
                return;
            }

            if ((firstDepartureDate.Date == System.DateTime.Now.Date) && (secondDepartureDate.Date ==DateTime.Now.Date.AddYears(1)))//если даты отправления не выбраны
            {
                if ((departure != null) && (arrival != null))//если указаны город отправления и прибытия
                { sql = "SELECT * FROM Flights WHERE  `Город отправления`='" + departure.ToString() + "' AND `Город прибытия`='" + arrival.ToString() + "';"; }
                if ((departure != null) && (arrival == null))//если указан только город отправления
                { sql = "SELECT * FROM Flights WHERE  `Город отправления`='" + departure.ToString() + "';"; }
                if ((departure == null) && (arrival != null))//если указан только город прибытия
                { sql = "SELECT * FROM Flights WHERE   `Город прибытия`='" + arrival.ToString() + "';"; }
            }

            else if (((departure == null) && (arrival == null)))
            {
                sql = "SELECT * FROM Flights WHERE `Дата отправления` BETWEEN '" + firstDepartureDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + secondDepartureDate.ToString("yyyy-MM-dd HH:mm:ss") + "';";
            }
            else
            {
                if ((departure != null) && (arrival != null))
                {
                    sql = "SELECT * FROM Flights WHERE  `Город отправления`='" + departure.ToString() + "' AND `Город прибытия`='" + arrival.ToString() + "' AND `Дата отправления` BETWEEN '" + firstDepartureDate + "' AND '" + secondDepartureDate.ToString("yyyy-MM-dd HH:mm:ss") + "';";
                }
                if ((departure != null) && (arrival == null))
                { sql = "SELECT * FROM Flights WHERE  `Город отправления`='" + departure.ToString() + "' AND `Дата отправления` BETWEEN '" + firstDepartureDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + secondDepartureDate.ToString("yyyy-MM-dd HH:mm:ss") + "';"; }
                if ((departure == null) && (arrival != null))
                { sql = "SELECT * FROM Flights WHERE   `Город прибытия`='" + arrival.ToString() + "' AND `Дата отправления` BETWEEN '" + firstDepartureDate.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + secondDepartureDate.ToString("yyyy-MM-dd HH:mm:ss") + "';"; }
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение

                    MySqlCommand command = new MySqlCommand(sql, connection);//объявляем команду
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(flightData);
                    connection.Close();//закрываем соединение
                    if (flightData.Rows.Count == 0)//Если в DataTabe ничего нет
                    {
                        MessageBox.Show("Поиск не дал результатов");
                        return;
                    }
                    else dataGrid.DataSource = flightData;
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
            }
        }

        public static bool CheckFlight(string flight)//метод для проверки существования определенного города
        {
            bool res = false;// результат отрицательный
            if (flight.Length == 5)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();//открываем подключение

                        MySqlCommand command = new MySqlCommand("check_flight", connection);//объявляем команду
                        command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура
                        MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - city
                        {
                            ParameterName = "flight_",//указываем имя параметра
                            MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                            Value = flight//передаем значение
                        };
                        command.Parameters.Add(parameter); //добавляем параметр
                        var reader = command.ExecuteReader();//Объявляем объект MySQLDataReader

                        if (reader.HasRows)//Если reader содержит одну или несколько строк
                        {
                            res = true;// результат положительный
                        }
                        reader.Close();//закрываем reader
                        connection.Close();//закрываем соединение
                    }
                    catch (Exception ex)//ловим исключение
                    {
                        MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                    }
                }
            }
            return res;//возвращаем результат проверки
        }
        //--------------------------------------------------------------------ПОКУПКА БИЛЕТА----------------------------------------------------------------//
        public static void getFlightInf(ref Flight flight)//метод для получения информации о билете
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем  соединение

                    MySqlCommand command = new MySqlCommand("get_flight_info", connection);//объявляем команду
                    command.CommandType = System.Data.CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter flightParameter = new MySqlParameter//задаем параметр ХП - код рейса
                    {
                        ParameterName = "flight_",//указываем имя параметра
                        Value = flight.flight//передаем значение
                    };
                    command.Parameters.Add(flightParameter);//добавляем параметр 

                    var reader = command.ExecuteReader();//создаем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            flight.airline = reader.GetString(1);//авиакомпания
                            flight.departureAirport = reader.GetString(2);//аэропорт отправления
                            flight.departureCity = reader.GetString(3);//город отправления
                            flight.arrivalAirport = reader.GetString(4);//аэропорт прибытия
                            flight.arrivalCity = reader.GetString(5);//город прибытия
                            flight.departureDate = reader.GetDateTime(6);//дата отправления
                            flight.arrivalDate = reader.GetDateTime(7);//дата прибытия
                            flight.standart = reader.GetInt32(8);//стандартный тариф
                            flight.extended = reader.GetInt32(9);//расширенный тариф
                            flight.full = reader.GetInt32(10);//полный тариф
                        }
                    }
                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }

        public static string getAirlineIcon(string airline)//метод для получения пути к изображению лого авиакомпании
        {
            string path = "E://airbookings//icons//";//целевая папка

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение

                    MySqlCommand command = new MySqlCommand("get_airline_icon", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура
                    MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - name
                    {
                        ParameterName = "name_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = airline//передаем значение
                    };
                    command.Parameters.Add(parameter); //добавляем параметр
                    var reader = command.ExecuteReader();//Объявляем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))//Если поле image не пустое
                            {
                                path += reader.GetString(0);//дополняем путь
                            }
                        }
                    }
                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
                return path;//возвращаем путь
            }
        }

        public static List<string> getSeats(string id_flight, string service_class)//метод для получения мест с определенным классом обслуживания
        {
            List<string> seats = new List<string>();//создаем новый список мест

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открывем подключение
                    MySqlCommand command = new MySqlCommand("free_seats", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура
                    MySqlParameter flightParameter = new MySqlParameter//задаем параметр ХП - номер рейса
                    {
                        ParameterName = "id_flight",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = id_flight//передаем значение
                    };
                    command.Parameters.Add(flightParameter); //добавляем параметр

                    MySqlParameter service_classParameter = new MySqlParameter//задаем параметр ХП - класс обслуживания
                    {
                        ParameterName = "service_class",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = service_class//передаем значение
                    };
                    command.Parameters.Add(service_classParameter); //добавляем параметр

                    var reader = command.ExecuteReader();//Объявляем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))//Если поле Название не пустое
                            {
                                seats.Add(reader.GetString(0));//добавляем значение в список стран
                            }
                        }
                    }
                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
                return seats;
            }
        }

        public static bool CheckPassengerData(string firstName, string middleName, string lastName, DateTime dateOfBirth, object citizenship, string number, string email)//метод для проверки данных пассажира
        {
            bool res = false;
            try
            {
                if (dateOfBirth.Date >= System.DateTime.Now.Date)
                {
                    MessageBox.Show("Дата рождения должна быть меньше текущей", "Предупреждение");//Выводим предупреждение
                    return res = false;
                }
                if ((firstName.Trim().Length == 0) ||
               (lastName.Trim().Length == 0) ||
               (citizenship == null) ||
               (number.Trim().Length == 0) ||
               (email.Trim().Length == 0))//Если одно или несколько полей пусты
                {
                    MessageBox.Show("Необходимо заполнить все данные о пассажире", "Предупреждение");//Выводим предупреждение
                    return res = false;
                }
                else
                {
                    if (!Regex.IsMatch(email, @"^\w+@gmail.com$"))
                    {
                        MessageBox.Show("Почта не соответствует формату \n\rФормат почты: somemail@gmail.com", "Сообщение", MessageBoxButtons.OK);//выводим сообщение об ошибке
                        return res = false;
                    }
                    else { res = true; }//результат - положительный
                }
            }
            catch (Exception ex)//ловим исключение
            {
                MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
            }
            return res;
        }
        public static int FindPassengerId(string sex, string firstname, string midname, string lastname, DateTime dateOfBirth, string citizenship, string passport, string email)//метод для нахождения id пассажира для добавления информации при покупке билета в БД
        {
            int idPassenger = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение
                    MySqlCommand command = new MySqlCommand("get_passenger_id", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter sexParameter = new MySqlParameter//задаем параметр ХП - sex
                    {
                        ParameterName = "sex_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = sex//передаем значение
                    };
                    command.Parameters.Add(sexParameter); //добавляем параметр

                    MySqlParameter firstnameParameter = new MySqlParameter//задаем параметр ХП - firstname
                    {
                        ParameterName = "firstname_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = firstname//передаем значение
                    };
                    command.Parameters.Add(firstnameParameter); //добавляем параметр

                    MySqlParameter midnameParameter = new MySqlParameter//задаем параметр ХП - midname
                    {
                        ParameterName = "midname_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = midname//передаем значение
                    };
                    command.Parameters.Add(midnameParameter); //добавляем параметр

                    MySqlParameter lastnameParameter = new MySqlParameter//задаем параметр ХП - lastname
                    {
                        ParameterName = "lastname_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = lastname//передаем значение
                    };
                    command.Parameters.Add(lastnameParameter); //добавляем параметр

                    MySqlParameter dateOfBirthParameter = new MySqlParameter//задаем параметр ХП - dateofbirth
                    {
                        ParameterName = "dateofbirth_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = dateOfBirth.ToString("yyyy-MM-dd HH:mm:ss")//передаем значение
                    };
                    command.Parameters.Add(dateOfBirthParameter); //добавляем параметр

                    MySqlParameter citizenshipParameter = new MySqlParameter//задаем параметр ХП - dateofbirth
                    {
                        ParameterName = "citizenship_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = citizenship//передаем значение
                    };
                    command.Parameters.Add(citizenshipParameter); //добавляем параметр

                    MySqlParameter passportParameter = new MySqlParameter//задаем параметр ХП - passport
                    {
                        ParameterName = "passport_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = passport//передаем значение
                    };
                    command.Parameters.Add(passportParameter); //добавляем параметр

                    MySqlParameter emailParameter = new MySqlParameter//задаем параметр ХП - email
                    {
                        ParameterName = "email_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = email//передаем значение
                    };
                    command.Parameters.Add(emailParameter); //добавляем параметр

                    var reader = command.ExecuteReader();//Объявляем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))//Если поле код не пустое
                            {
                                idPassenger = Convert.ToInt32(reader.GetString(0));//добавляем значение в список кодов
                            }
                        }
                    }
                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
                return idPassenger;//возвращаем код города
            }
        }

        public static void addNewPassenger(string sex, string firstname, string midname, string lastname, DateTime dateOfBirth, string citizenship, string passport, string email)//метод для добавления нового пассажира в систему
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение
                    MySqlCommand command = new MySqlCommand("add_new_passenger", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter sexParameter = new MySqlParameter//задаем параметр ХП - sex
                    {
                        ParameterName = "sex_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = sex//передаем значение
                    };
                    command.Parameters.Add(sexParameter); //добавляем параметр

                    MySqlParameter firstnameParameter = new MySqlParameter//задаем параметр ХП - firstname
                    {
                        ParameterName = "firstname_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = firstname//передаем значение
                    };
                    command.Parameters.Add(firstnameParameter); //добавляем параметр

                    MySqlParameter midnameParameter = new MySqlParameter//задаем параметр ХП - midname
                    {
                        ParameterName = "midname_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = midname//передаем значение
                    };
                    command.Parameters.Add(midnameParameter); //добавляем параметр

                    MySqlParameter lastnameParameter = new MySqlParameter//задаем параметр ХП - lastname
                    {
                        ParameterName = "lastname_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = lastname//передаем значение
                    };
                    command.Parameters.Add(lastnameParameter); //добавляем параметр

                    MySqlParameter dateOfBirthParameter = new MySqlParameter//задаем параметр ХП - dateofbirth
                    {
                        ParameterName = "dateofbirth_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = dateOfBirth.ToString("yyyy-MM-dd HH:mm:ss")//передаем значение
                    };
                    command.Parameters.Add(dateOfBirthParameter); //добавляем параметр

                    MySqlParameter citizenshipParameter = new MySqlParameter//задаем параметр ХП - dateofbirth
                    {
                        ParameterName = "citizenship_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = FindCountryCode(citizenship)//передаем значение
                    };
                    command.Parameters.Add(citizenshipParameter); //добавляем параметр

                    MySqlParameter passportParameter = new MySqlParameter//задаем параметр ХП - passport
                    {
                        ParameterName = "passport_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = passport//передаем значение
                    };
                    command.Parameters.Add(passportParameter); //добавляем параметр

                    MySqlParameter emailParameter = new MySqlParameter//задаем параметр ХП - email
                    {
                        ParameterName = "email_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = email//передаем значение
                    };
                    command.Parameters.Add(emailParameter); //добавляем параметр

                    command.ExecuteNonQuery();
                    MessageBox.Show("Вроде зарегались");
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
            }
        }
        public static int FindServiceClassId(string service_class)//метод для нахождения кода класса обслуживания при добавлении бронирования в систему
        {
            int serviceClassId = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем  соединение
                    MySqlCommand command = new MySqlCommand("get_service_class_id", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - service_class
                    {
                        ParameterName = "service_class_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = service_class//передаем значение
                    };
                    command.Parameters.Add(parameter); //добавляем параметр
                    var reader = command.ExecuteReader();//создаем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))//Если поле код не пустое
                            {
                                serviceClassId = Convert.ToInt32(reader.GetString(0));//добавляем значение в список кодов
                            }
                        }
                    }

                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
                return serviceClassId;//возвращаем код города
            }
        }

        public static int FindRateId(string rate)//метод для нахождения кода тарифа при добавлении бронирования в систему
        {
            int rateId = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем  соединение
                    MySqlCommand command = new MySqlCommand("get_rate_id", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - service_class
                    {
                        ParameterName = "rate_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = rate//передаем значение
                    };
                    command.Parameters.Add(parameter); //добавляем параметр
                    var reader = command.ExecuteReader();//создаем объект MySQLDataReader

                    if (reader.HasRows)//Если reader содержит одну или несколько строк
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))//Если поле код не пустое
                            {
                                rateId = Convert.ToInt32(reader.GetString(0));//добавляем значение в список кодов
                            }
                        }
                    }

                    reader.Close();//закрываем reader
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
                return rateId;//возвращаем код города
            }
        }

        public static void addNewTicket(string bookingCode, string flight, string service_class, int passenger, string user, string rate, string seat, int cost)//метод для добавления в систему информации о новом билете
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение
                    MySqlCommand command = new MySqlCommand("add_new_ticket", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter bookingCodeParameter = new MySqlParameter//задаем параметр ХП - bookingCode
                    {
                        ParameterName = "bookingCode_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = bookingCode//передаем значение
                    };
                    command.Parameters.Add(bookingCodeParameter); //добавляем параметр

                    MySqlParameter bookingDateParameter = new MySqlParameter//задаем параметр ХП - bookingDate
                    {
                        ParameterName = "bookingDate_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.Date,//указываем тип параметра
                        Value = DateTime.Now.Date//передаем значение
                    };
                    command.Parameters.Add(bookingDateParameter); //добавляем параметр

                    MySqlParameter statusParameter = new MySqlParameter//задаем параметр ХП - status
                    {
                        ParameterName = "status_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.Int32,//указываем тип параметра
                        Value = 1//передаем значение
                    };
                    command.Parameters.Add(statusParameter); //добавляем параметр

                    MySqlParameter flightParameter = new MySqlParameter//задаем параметр ХП - flight
                    {
                        ParameterName = "flight_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = flight//передаем значение
                    };
                    command.Parameters.Add(flightParameter); //добавляем параметр

                    MySqlParameter service_classParameter = new MySqlParameter//задаем параметр ХП - service_class
                    {
                        ParameterName = "service_class_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.Int32,//указываем тип параметра
                        Value = FindServiceClassId(service_class)//передаем значение
                    };
                    command.Parameters.Add(service_classParameter); //добавляем параметр

                    MySqlParameter passengerParameter = new MySqlParameter//задаем параметр ХП - passenger
                    {
                        ParameterName = "passenger_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.Int32,//указываем тип параметра
                        Value = passenger//передаем значение
                    };
                    command.Parameters.Add(passengerParameter); //добавляем параметр

                    MySqlParameter userParameter = new MySqlParameter//задаем параметр ХП - user
                    {
                        ParameterName = "user_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = user//передаем значение
                    };
                    command.Parameters.Add(userParameter); //добавляем параметр

                    MySqlParameter rateParameter = new MySqlParameter//задаем параметр ХП - rate
                    {
                        ParameterName = "rate_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.Int32,//указываем тип параметра
                        Value = FindRateId(rate)//передаем значение
                    };
                    command.Parameters.Add(rateParameter); //добавляем параметр

                    MySqlParameter seatParameter = new MySqlParameter//задаем параметр ХП - seat
                    {
                        ParameterName = "seat_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = seat//передаем значение
                    };
                    command.Parameters.Add(seatParameter); //добавляем параметр

                    MySqlParameter costParameter = new MySqlParameter//задаем параметр ХП - rate
                    {
                        ParameterName = "cost_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.Int32,//указываем тип параметра
                        Value = cost//передаем значение
                    };
                    command.Parameters.Add(costParameter); //добавляем параметр

                    command.ExecuteNonQuery();
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
            }
        }

        public static void addNewTakenSeat(string ticket, string seat, string flight)//метод для добавления в систему информации о занятом месте
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение
                    MySqlCommand command = new MySqlCommand("add_new_taken_seat", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедураx

                    MySqlParameter ticketParameter = new MySqlParameter//задаем параметр ХП - ticket
                    {
                        ParameterName = "ticket_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = ticket//передаем значение
                    };
                    command.Parameters.Add(ticketParameter); //добавляем параметр

                    MySqlParameter seatParameter = new MySqlParameter//задаем параметр ХП - seat
                    {
                        ParameterName = "seat_id_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = seat//передаем значение
                    };
                    command.Parameters.Add(seatParameter); //добавляем параметр

                    MySqlParameter flightParameter = new MySqlParameter//задаем параметр ХП - flight
                    {
                        ParameterName = "flight_id_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = flight//передаем значение
                    };
                    command.Parameters.Add(flightParameter); //добавляем параметр

                    command.ExecuteNonQuery();
                    MessageBox.Show("Бронирование подтверждено");
                    connection.Close();//закрываем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
            }
        }

    //--------------------------------------------------------------------МОИ БРОНИРОВАНИЯ-------------------------------------------------------------//
        public static void GetMyBookingsInfo(DataGridView dataGrid, string user)
        {
            DataTable flightData = new DataTable();//Создаем объект DataTable
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение

                    MySqlCommand command = new MySqlCommand("get_my_bookings_info", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура
                    MySqlParameter Parameter = new MySqlParameter//задаем параметр ХП - ticket
                    {
                        ParameterName = "user_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = user//передаем значение
                    };
                    command.Parameters.Add(Parameter); //добавляем параметр

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(flightData);
                    connection.Close();//закрываем соединение
                    if (flightData.Rows.Count == 0)//Если в DataTabe ничего нет
                    {
                        MessageBox.Show("Нет доступных бронирований");
                    }
                    else dataGrid.DataSource = flightData;

                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
            }
        }

        public static void GetAllBookingsInfo(DataGridView dataGrid)
        {
            DataTable flightData = new DataTable();//Создаем объект DataTable
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение

                    MySqlCommand command = new MySqlCommand("get_all_bookings_info", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(flightData);
                    connection.Close();//закрываем соединение
                    if (flightData.Rows.Count == 0)//Если в DataTabe ничего нет
                    {
                        MessageBox.Show("Нет доступных бронирований");
                    }
                    else dataGrid.DataSource = flightData;

                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
            }
        }

        public static bool CheckBooking(string booking)//метод для проверки существования определенного города
        {
            bool res = false;// результат отрицательный
            if (booking.Length == 5)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();//открываем подключение

                        MySqlCommand command = new MySqlCommand("check_booking", connection);//объявляем команду
                        command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура
                        MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - city
                        {
                            ParameterName = "booking_",//указываем имя параметра
                            MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                            Value = booking//передаем значение
                        };
                        command.Parameters.Add(parameter); //добавляем параметр
                        var reader = command.ExecuteReader();//Объявляем объект MySQLDataReader

                        if (reader.HasRows)//Если reader содержит одну или несколько строк
                        {
                            res = true;// результат положительный
                        }
                        reader.Close();//закрываем reader
                        connection.Close();//закрываем соединение
                    }
                    catch (Exception ex)//ловим исключение
                    {
                        MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                    }
                }
            }
            return res;//возвращаем результат проверки
        }

        public static BookingPassenger GetPassengerByFullname(string fullname)//Метод для получения пассажира по email'у
        {
            DataSet data = new DataSet();//Создаем объект DataSet

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand("get_passenger_by_fullname", connection);//объявляем команду
                command.CommandType = System.Data.CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                MySqlParameter parameter = new MySqlParameter//задаем параметр ХП - email
                {
                    ParameterName = "fullname_",//указываем имя параметра
                    MySqlDbType = MySqlDbType.VarChar,//задаем тип параметра
                    Value = fullname//передаем значение
                };
                //добавляем параметр 
                command.Parameters.Add(parameter);
                //объявляем объект MySQLDataAdapter
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;//выбираем команду
                try
                {
                    connection.Open();//открываем соединение
                    adapter.Fill(data);//заполняем adapter
                    connection.Close();//закрывем соединение
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
            if (data.Tables[0].Rows.Count == 0)//Если в DataTabe ничего нет
            {
                return null;//возвращаем пустое значение
            }
            else//иначе
            {

                BookingPassenger bookingPassenger = new BookingPassenger();//объявляем экземпляр класса Passenger
                bookingPassenger.id = Convert.ToInt32(data.Tables[0].Rows[0]["id"]);//заполняем поле id
                bookingPassenger.sex = data.Tables[0].Rows[0]["Пол"].ToString();//заполняем поле пол
                bookingPassenger.firstname = data.Tables[0].Rows[0]["Имя"].ToString();//заполняем поле первое имя
                bookingPassenger.midname = data.Tables[0].Rows[0]["Отчество"].ToString(); ;//заполняем поле второе имя
                bookingPassenger.lastname = data.Tables[0].Rows[0]["Фамилия"].ToString(); ;//заполняем поле последнее имя
                bookingPassenger.birthday = DateTime.Parse(data.Tables[0].Rows[0]["ДатаРождения"].ToString());//дата рождения
                bookingPassenger.citizen = data.Tables[0].Rows[0]["Гражданство"].ToString();//гражданство
                bookingPassenger.passport = data.Tables[0].Rows[0]["Паспорт"].ToString();//паспорт
                bookingPassenger.email = data.Tables[0].Rows[0]["email"].ToString();//email
                return bookingPassenger;//метод возвращает экземпляр класса Passenger passenger
            }
        }

        public static void DeleteTakenSeat(string bookingCode)//метод для удаления учетной записи
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    DialogResult result = MessageBox.Show("Вы уверены? Бронирование будет отменено", "Предупреждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand("delete_taken_seat", connection);//объявляем команду
                        command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                        MySqlParameter Parameter = new MySqlParameter//задаем параметр ХП - bookingCode
                        {
                            ParameterName = "ticket_",//указываем имя параметра
                            MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                            Value = bookingCode//передаем значение
                        };
                        command.Parameters.Add(Parameter); //добавляем параметр

                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }
        public static void DeleteMyBooking(string bookingCode)//метод для удаления учетной записи
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand("delete_mybooking", connection);//объявляем команду
                        command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                        MySqlParameter Parameter = new MySqlParameter//задаем параметр ХП - bookingCode
                        {
                            ParameterName = "bookingCode_",//указываем имя параметра
                            MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                            Value = bookingCode//передаем значение
                        };
                        command.Parameters.Add(Parameter); //добавляем параметр

                        command.ExecuteNonQuery();
                        connection.Close();
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }

        //--------------------------------------------------------------------АДМИНИСТРИРОВАНИЕ-------------------------------------------------------------//

        public static void GetInfo(DataGridView dataGrid, string table_name)//метод для выгрузки таблиц из системы
        {
            DataTable Data = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение

                    MySqlCommand command = new MySqlCommand("select * from "+table_name+";", connection);//объявляем команду
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(Data);
                        connection.Close();//закрываем соединение
                        if (Data.Rows.Count == 0)//Если в DataTabe ничего нет
                        {
                            MessageBox.Show("Нет записей");
                        }
                        else dataGrid.DataSource = Data;
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
            }
        }

        public static void deleteInfo(string table_name, string parameter, string value)//метод для удаления записей из таблиц
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//открываем подключение

                    MySqlCommand command = new MySqlCommand("delete from " + table_name + " where " + parameter + " = '" + value +"'; ", connection);//объявляем команду
                    command.ExecuteNonQuery();
                    connection.Close();//закрываем соединение
                    MessageBox.Show("Информация успешно удалена");
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке 
                }
            }
        }

        public static void addUpdateAirline(string use,string IATA, string name, string ICAO, string image)//метод для добавления и обновления записей таблицы airline
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(use+"_airline", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter IATAParameter = new MySqlParameter//задаем параметр ХП - IATA
                    {
                        ParameterName = "IATA_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = IATA//передаем значение
                    };
                    command.Parameters.Add(IATAParameter); //добавляем параметр
                    MySqlParameter nameParameter = new MySqlParameter//задаем параметр ХП - name
                    {
                        ParameterName = "name_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = name//передаем значение
                    };
                    command.Parameters.Add(nameParameter); //добавляем параметр

                    MySqlParameter ICAOParameter = new MySqlParameter//задаем параметр ХП - ICAO
                    {
                        ParameterName = "ICAO_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = ICAO//передаем значение
                    };
                    command.Parameters.Add(ICAOParameter); //добавляем параметр

                    MySqlParameter imageParameter = new MySqlParameter//задаем параметр ХП - image
                    {
                        ParameterName = "image_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = image//передаем значение
                    };
                    command.Parameters.Add(imageParameter); //добавляем параметр
                    command.ExecuteNonQuery();
                    connection.Close();
                    if(use == "update") MessageBox.Show("Информация успешно обновлена");
                    if (use == "add") MessageBox.Show("Информация успешно добавлена");
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }

        public static void addUpdateAirport (string use, string IATA, string name,string city, string country, string ICAO, string coordinates)
        {
            if (!CheckCity(city))//Если введенного города не существует
            {
                MessageBox.Show("Неизвестный город, попробуйте ввести другой", "Предупреждение");//Выводим предупреждение
                return;
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(use + "_airport", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter IATAParameter = new MySqlParameter//задаем параметр ХП - IATA
                    {
                        ParameterName = "IATA_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = IATA//передаем значение
                    };
                    command.Parameters.Add(IATAParameter); //добавляем параметр
                    MySqlParameter nameParameter = new MySqlParameter//задаем параметр ХП - name
                    {
                        ParameterName = "name_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = name//передаем значение
                    };
                    command.Parameters.Add(nameParameter); //добавляем параметр

                    MySqlParameter cityParameter = new MySqlParameter//задаем параметр ХП - city
                    {
                        ParameterName = "city_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.Int32,//указываем тип параметра
                        Value = FindCityCode(city)//передаем значение
                    };
                    command.Parameters.Add(cityParameter); //добавляем параметр

                    MySqlParameter countryParameter = new MySqlParameter//задаем параметр ХП -  country
                    {
                        ParameterName = "country_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = FindCountryCode(country)//передаем значение
                    };
                    command.Parameters.Add(countryParameter); //добавляем параметр

                    MySqlParameter ICAOParameter = new MySqlParameter//задаем параметр ХП - ICAO
                    {
                        ParameterName = "ICAO_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = ICAO//передаем значение
                    };
                    command.Parameters.Add(ICAOParameter); //добавляем параметр

                    MySqlParameter coordinatesParameter = new MySqlParameter//задаем параметр ХП - image
                    {
                        ParameterName = "coordinates_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = coordinates//передаем значение
                    };
                    command.Parameters.Add(coordinatesParameter); //добавляем параметр
                    command.ExecuteNonQuery();
                    connection.Close();
                    if (use == "update") MessageBox.Show("Информация успешно обновлена");
                    if (use == "add") MessageBox.Show("Информация успешно добавлена");
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }

        public static void addFlight(string flight, string departair, string departcity, string arriveair, string arrivecity, string dep, string arr, string airline)

        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("add_flight", connection);//объявляем команду
                    command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                    MySqlParameter flightParameter = new MySqlParameter//задаем параметр ХП - flight
                    {
                        ParameterName = "flight_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = flight//передаем значение
                    };
                    command.Parameters.Add(flightParameter); //добавляем параметр

                    MySqlParameter departairParameter = new MySqlParameter//задаем параметр ХП - name
                    {
                        ParameterName = "departureAirport_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = departair//передаем значение
                    };
                    command.Parameters.Add(departairParameter); //добавляем параметр

                    MySqlParameter cityParameter = new MySqlParameter//задаем параметр ХП - city
                    {
                        ParameterName = "departureCity_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.Int32,//указываем тип параметра
                        Value = FindCityCode(departcity)//передаем значение
                    };
                    command.Parameters.Add(cityParameter); //добавляем параметр

                    MySqlParameter arriveairParameter = new MySqlParameter//задаем параметр ХП - name
                    {
                        ParameterName = "arrivalAirport_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = arriveair//передаем значение
                    };
                    command.Parameters.Add(arriveairParameter); //добавляем параметр

                    MySqlParameter acityParameter = new MySqlParameter//задаем параметр ХП - city
                    {
                        ParameterName = "arrivalCity_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.Int32,//указываем тип параметра
                        Value = FindCityCode(arrivecity)//передаем значение
                    };
                    command.Parameters.Add(acityParameter); //добавляем параметр

                    MySqlParameter depParameter = new MySqlParameter//задаем параметр ХП - city
                    {
                        ParameterName = "departureDate_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.DateTime,//указываем тип параметра
                        Value = dep//передаем значение
                    };
                    command.Parameters.Add(depParameter); //добавляем параметр
                    MySqlParameter arrParameter = new MySqlParameter//задаем параметр ХП - city
                    {
                        ParameterName = "arrivalDate_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.DateTime,//указываем тип параметра
                        Value = arr//передаем значение
                    };
                    command.Parameters.Add(arrParameter); //добавляем параметр

                    MySqlParameter airlineParameter = new MySqlParameter//задаем параметр ХП - name
                    {
                        ParameterName = "airline_",//указываем имя параметра
                        MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                        Value = airline//передаем значение
                    };
                    command.Parameters.Add(airlineParameter); //добавляем параметр

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Информация успешно добавлена");
                }
                catch (Exception ex)//ловим исключение
                {
                    MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                }
            }
        }

        public static void addFlightCost(string flight, string standart, string extended, string full)
        {
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand("add_flight_COST", connection);//объявляем команду
                        command.CommandType = CommandType.StoredProcedure;//указываем тип команды - хранимая процедура

                        MySqlParameter flightParameter = new MySqlParameter//задаем параметр ХП - flight
                        {
                            ParameterName = "flight_",//указываем имя параметра
                            MySqlDbType = MySqlDbType.VarChar,//указываем тип параметра
                            Value = flight//передаем значение
                        };
                        command.Parameters.Add(flightParameter); //добавляем параметр

                        MySqlParameter standartParameter = new MySqlParameter//задаем параметр ХП - name
                        {
                            ParameterName = "standart_",//указываем имя параметра
                            MySqlDbType = MySqlDbType.Decimal,//указываем тип параметра
                            Value = standart//передаем значение
                        };
                        command.Parameters.Add(standartParameter); //добавляем параметр
                        MySqlParameter extendedParameter = new MySqlParameter//задаем параметр ХП - name
                        {
                            ParameterName = "extended_",//указываем имя параметра
                            MySqlDbType = MySqlDbType.Decimal,//указываем тип параметра
                            Value = extended//передаем значение
                        };
                        command.Parameters.Add(extendedParameter); //добавляем параметр
                        MySqlParameter fullParameter = new MySqlParameter//задаем параметр ХП - name
                        {
                            ParameterName = "full_",//указываем имя параметра
                            MySqlDbType = MySqlDbType.Decimal,//указываем тип параметра
                            Value = full//передаем значение
                        };
                        command.Parameters.Add(fullParameter); //добавляем параметр



                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Информация успешно добавлена");
                    }
                    catch (Exception ex)//ловим исключение
                    {
                        MessageBox.Show(ex.ToString());//выводим сообщение об ошибке
                    }
                }
            }
        }
    }
}


