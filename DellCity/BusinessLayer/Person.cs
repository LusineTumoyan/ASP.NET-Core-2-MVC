using DataAccessLayer.DBTools;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Person : IDataMapper
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public bool? IsAlive { get; set; }
        public static object DataAccess { get; private set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, bool? gender, DateTime? birthDate, string phone, string mail, string address, string nationality, bool? isAlive)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            BirthDate = birthDate;
            Phone = phone;
            Mail = mail;
            Address = address;
            Nationality = nationality;
            IsAlive = isAlive;
        }

        public void MapEntity(SqlDataReader reader)
        {
            Id = Convert.ToInt32(reader["Id"]);
            FirstName = Convert.ToString(reader["FirstName"]);
            LastName = Convert.ToString(reader["LastName"]);
            Gender = Convert.ToBoolean(reader["Gender"]);
            BirthDate = Convert.ToDateTime(reader["BirthDate"]); ;
            Phone = Convert.ToString(reader["Phone"]);
            Mail = Convert.ToString(reader["Mail"]);
            Address = Convert.ToString(reader["Address"]);
            Nationality = Convert.ToString(reader["Nationality"]);
            IsAlive = Convert.ToBoolean(reader["IsAlive"]);
        }

        public static async Task<List<Person>> GetAllPerson()
        {
            return await DBAccess.ExecuteSPWithListResult<Person>("SelectAll", null);
        }

        public async Task CreatePerson()
        {
            List<SPParam> list = new List<SPParam>()
            {
                new SPParam("@FirstName", this.FirstName),
                new SPParam("@LastName", this.LastName),
                new SPParam("@Gender", this.Gender),
                new SPParam("@BirthDate", this.BirthDate),
                new SPParam("@Phone", this.Phone),
                new SPParam("@Mail", this.Mail),
                new SPParam("@Address", this.Address),
                new SPParam("@Nationality", this.Nationality),
                new SPParam("@IsAlive", this.IsAlive)
            };

            await DBAccess.ExecuteSPWithNoResult<Person>("AddPerson", list);
        }

        public async Task UpdatePerson()
        {
            List<SPParam> list = new List<SPParam>()
            {
                new SPParam("@Id", this.Id),
                new SPParam("@FirstName", this.FirstName),
                new SPParam("@LastName", this.LastName),
                new SPParam("@Gender", this.Gender),
                new SPParam("@BirthDate", this.BirthDate),
                new SPParam("@Phone", this.Phone),
                new SPParam("@Mail", this.Mail),
                new SPParam("@Address", this.Address),
                new SPParam("@Nationality", this.Nationality),
                new SPParam("@IsAlive", this.IsAlive)
            };

            await DBAccess.ExecuteSPWithNoResult<Person>("UpdatePerson", list);
        }

        public async Task DeletePerson()
        {
            List<SPParam> list = new List<SPParam>()
            {
                new SPParam("@Id", this.Id),
                new SPParam("@FirstName", this.FirstName),
                new SPParam("@LastName", this.LastName),
                new SPParam("@Gender", this.Gender),
                new SPParam("@BirthDate", this.BirthDate),
                new SPParam("@Phone", this.Phone),
                new SPParam("@Mail", this.Mail),
                new SPParam("@Address", this.Address),
                new SPParam("@Nationality", this.Nationality),
                new SPParam("@IsAlive", this.IsAlive)
            };

            await DBAccess.ExecuteSPWithNoResult<Person>("DeletePerson", list);
        }
    }
}