﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
	public class Testimonial
	{
		public int TestimonialId { get; set; }
		public string Name { get; set; }
		public string Title { get; set; }
		public string ImageUrl { get; set; }
		public string Comment { get; set; }
		public int Star { get; set; }// Yıldız sayısı, 1-5 arasında bir değer alabilir

	}
}
