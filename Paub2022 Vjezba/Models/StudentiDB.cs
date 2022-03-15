using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Paub2022_Vjezba.Models
{


    public class StudentiDB
    {
        private List<Student> lista = new List<Student>();


        public StudentiDB()
        {
            lista.Add(new Student()
            {
                ID = 1,
                Prezime = "Ivić",
                Ime = "Petar",
                Spol = 'M',
                DatumRodjenja = new DateTime(1991, 02, 01),
                Oib = "12345678901",
                RedovanStudent = true
            });
            lista.Add(new Student()
            {
                ID = 2,
                Prezime = "Ivanović",
                Ime = "Marta",
                Spol = 'Z',
                DatumRodjenja = new DateTime(1991, 03, 02),
                Oib = "12345671232",
                RedovanStudent = true
            });
           lista.Add(new Student()
            {
                ID = 3,
                Prezime = "Marić",
                Ime = "Jakov",
                Spol = 'M',
                DatumRodjenja = new DateTime(1991, 04, 01),
                Oib = "11234321231",
                RedovanStudent = true
            });

            lista.Add(new Student()
            {
                ID = 4,
                Prezime = "Bedis",
                Ime = "Barbara",
                Spol = 'Z',
                DatumRodjenja = new DateTime(1991, 02, 01),
                Oib = "12345678901",
                RedovanStudent = true

            });
        }
        public List<Student> VratiListu()
        {
            return lista;
        }
    }
   
}










