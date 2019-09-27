namespace webEval.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum Gender
    {
        male,
        female
    }

    public class student
    {
        public int scoreID { get; set; }

        public string name { get; set; }

        public Gender Sex { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }




    }
}