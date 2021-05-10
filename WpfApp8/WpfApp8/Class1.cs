using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    class Class1
    {       
        //Регистрация пользователя
        public void AddPerson(string Name, string lastname, DateTime age)
        {
            using (avtorEntities2 registorBD = new avtorEntities2())
            {
                registorBD.Persona.Add(new Persona
                {
                    Firs_Name = Name,
                    Last_Name = lastname,
                    age=age,
                });
                registorBD.SaveChanges();

            }
        }
         
        //регистрация  юзера
        public void AddUser( string login, string password)
        {
            using (avtorEntities2 UserAD = new avtorEntities2())
            {
                UserAD.User.Add(new User
                {
                    kod_Person = UserAD.Persona.OrderByDescending(p=>p.kod_persona).First().kod_persona,
                    Login = login,
                    Password = password

                });
                

                UserAD.SaveChanges();

            }

        }
        

    }   
}

