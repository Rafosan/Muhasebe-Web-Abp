using FluentValidation;
using MuhasebeWeb.Application.Contracts.AlimTuru;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Contracts.Gider
{
	public class UpdateGiderDTO
	{
		public string Gider { get; set; }
	}
	public class UpdateGiderDTOValidator : AbstractValidator<UpdateGiderDTO>
	{
		public UpdateGiderDTOValidator()
		{
			RuleFor(x => x.Gider)
				.NotEmpty().WithMessage("Alim Türü boş olamaz")
				.NotNull().WithMessage("Alim Türü boş olamaz")
				.Length(1, 50).WithMessage("Alim Türü uzunluğu 1-50 karakter arası olmalı");
		}
	}
}
