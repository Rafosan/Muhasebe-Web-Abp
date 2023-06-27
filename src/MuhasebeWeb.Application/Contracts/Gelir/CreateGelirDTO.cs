using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Contracts.Gelir
{
	public class CreateGelirDTO
	{
		public string Gelir { get; set; }
	}
	public class CreateGelirDTOValidator : AbstractValidator<CreateGelirDTO>
	{
		public CreateGelirDTOValidator()
		{
			RuleFor(x => x.Gelir)
				.NotEmpty().WithMessage("Gelir boş olamaz")
				.NotNull().WithMessage("Gelir boş olamaz")
				.Length(1, 50).WithMessage("Gelir uzunluğu 1-50 karakter arası olmalı");
		}
	}
}
