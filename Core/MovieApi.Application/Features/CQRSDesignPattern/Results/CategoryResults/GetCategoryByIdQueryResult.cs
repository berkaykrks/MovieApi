﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults
{
	public class GetCategoryByIdQueryResult
	{
		public int CategoryId { get; set; }
		public String CategoryName { get; set; }
	}
}
