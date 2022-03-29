using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Paub2022_Vjezba.Models
{
    public class Student
    {  
        [Display(Name="ID studenta")]
        public int ID { get; set; }
        [Display(Name = "Ime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30,MinimumLength =2, ErrorMessage ="{0} mora biti duljine minimalno {2} a maksimalno {1} znakova")]
        public string  Ime { get; set; }
        [Display(Name = "Prezime")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "{0} mora biti duljine minimalno {2} a maksimalno {1} znakova")]
        public string Prezime { get; set; }
        [Display(Name = "Spol")]
        public char Spol { get; set; }
        [Display(Name = "OIB")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "{0} mora biti duljine {1} znakova")]
        public string Oib { get; set; }
        [Display(Name = "Datum rođenja")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [Required(ErrorMessage = "{0} je obavezno")]
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }
        [Display(Name = "Godina studija")]
        public int GodinaStudija { get; set;}
        [Display(Name = "Redovan student")]
        public bool RedovanStudent { get; set; }


        [Display(Name = "Broj upisanih kolegija")]
        [Required(ErrorMessage = "{0} je obavezno")]
        [Range(1,8,ErrorMessage = "{0} mora biti duljine izmedu {1} i {2}")]
        public int BrojUpisanihKolegija { get; set; }
    }
}