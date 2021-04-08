using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Lab11.ViewModels
{
    public enum Category
    {
        Manager, TeamLeader, Worker
    }

    public class WorkerViewModel
    {
        public int Id { get; set; }
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "E-mail is required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid email provided. A valid email is e.g. pwr@gmail.com")]
        public string Email { get; set; }
        [Display(Name = "Last name")]
        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression("[A-Z]{1}[a-zA-Z]{2,39}", ErrorMessage = "Invalid last name.")]
        [MaxLength(40, ErrorMessage = "To long last name, do not exceed {0}")]
        public string Name { get; set; }
        [Display(Name = "Zip code")]
        [Required(ErrorMessage = "Zip code is required")]
        [RegularExpression(@"^[0-9]{2}-[0-9]{3}$", ErrorMessage = "Zip code must have format '00-000'")]
        public string ZipCode { get; set; }
        public Category Category { get; set; }

        public WorkerViewModel()
        {

        }

        public WorkerViewModel(int id, string emial, string name, string zipCode, Category category)
        {
            this.Id = id;
            this.Email = emial;
            this.Name = name;
            this.ZipCode = zipCode;
            this.Category = category;
        }
    }
}
