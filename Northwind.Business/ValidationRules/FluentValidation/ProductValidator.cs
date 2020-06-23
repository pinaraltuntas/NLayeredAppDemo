﻿using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
	public class ProductValidator:AbstractValidator<Product>
	{
		public ProductValidator()
		{
			//fluent Validation
			RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");
			RuleFor(p => p.CategoryId).NotEmpty();
			RuleFor(p => p.QuantityPerUnit).NotEmpty();
			RuleFor(p => p.UnitPrice).NotEmpty();
			RuleFor(p => p.UnitsInStock).NotEmpty();
			  
			RuleFor(p => p.UnitPrice).GreaterThan(0);
			RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo((short)0);
			RuleFor(p=>p.UnitPrice).GreaterThan(15).When(p=>p.CategoryId==2);

			RuleFor(p => p.ProductName).Must(StartWithA);
		}

		private bool StartWithA(string arg)
		{
			return arg.StartsWith("A");
		}
	}
}
