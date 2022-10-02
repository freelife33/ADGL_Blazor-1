﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGL_Blazor.Models
{
    public class CourseDto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Kurs adını giriniz.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Kurs fiyatını giriniz")]
        public decimal CoursePrice { get; set; }

        [Required(ErrorMessage = "Must be selected Is-Active")]
        public bool IsActive { get; set; } = true;
        public string? Description { get; set; }
        [Required(ErrorMessage = "Kurs başlığını giriniz.")]
        public string? Title { get; set; }
        public string? SubTitle { get; set; }
        public double RegularRate { get; set; }
        public string? Details { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string? ImageUrl { get; set; }
        public int TotalCount { get; set; }
    }
}
