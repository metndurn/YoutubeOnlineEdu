﻿using Microsoft.EntityFrameworkCore;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Context
{
	public class OnlineEduContext : DbContext
	{
		/*veritabanı baglantısı yerıdır ve butun herseyı appsettings.json tarafında tutulacak
		 o yuzden burada base olarak aldık buda api tarafındadır*/
		public OnlineEduContext(DbContextOptions options) : base(options)
		{

		}

		/*burada butun tabloları yazdık ve set ettık yanı buraya yazarken verı tabanına
		 yazdırmak ıcın kullanıyoruz*/
		public DbSet<About> Abouts { get; set; }
		public DbSet<Banner> Banners { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<BlogCategory> BlogCategories { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<CourseCategory> CourseCategories { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Subscriber> Subscribers { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
	}
}
