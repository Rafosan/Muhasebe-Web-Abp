using FluentValidation;
using MuhasebeWeb.Application.Contracts.AlimTuru;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Contracts.Gelir
{
	public class UpdateGelirDTO
	{
		public string Gelir { get; set; }
	}
	public class UpdateGelirDTOValidator : AbstractValidator<UpdateGelirDTO>
	{
		public UpdateGelirDTOValidator()
		{
			RuleFor(x => x.Gelir)
				.NotEmpty().WithMessage("Gelir boş olamaz")
				.NotNull().WithMessage("Gelir boş olamaz")
				.Length(1, 50).WithMessage("Gelir uzunluğu 1-50 karakter arası olmalı");
		}
	}
}
