﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
	public class CourseCategory
	{
		public int CourseCategoryId { get; set; }
		public string Name { get; set; }
		public string Icon { get; set; }
		public string Description { get; set; }
		public bool IsShown { get; set; }//true yada false olarak
		public List<Course> Courses { get; set; }//course kısmında kategorı verdıgımız ıcın burada kursların lıste halınde gelmesı gerektıgı ıcın bu yazılıyor
	}
}
