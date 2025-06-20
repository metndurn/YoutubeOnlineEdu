using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
	public class Course
	{
		public int CourseId { get; set; }
		public string CourseName { get; set; }
		public string ImageUrl { get; set; }
		public decimal Price { get; set; }
		public bool IsShown { get; set; }//anasayfada gorunup gorunmesın mı dıye yazıldı
		public int CategoryId { get; set; }//kursta ait oldugu kategorinin id'si
		public CourseCategory category { get; set; }//category sınıfına erısım olması ıcın burada yazıldı
	}
}
