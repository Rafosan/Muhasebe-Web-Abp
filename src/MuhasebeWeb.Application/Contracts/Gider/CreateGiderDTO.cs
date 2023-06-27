using FluentValidation;
using MuhasebeWeb.Application.Contracts.AlimTuru;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhasebeWeb.Contracts.Gider
{
	public class CreateGiderDTO
	{
		public string Gider { get; set; }
	}
	public class CreateGiderDTOValidator : AbstractValidator<CreateGiderDTO>
	{
		public CreateGiderDTOValidator()
		{
			RuleFor(x => x.Gider)
				.NotEmpty().WithMessage("Gider boş olamaz")
				.NotNull().WithMessage("Gider boş olamaz")
				.Length(1, 50).WithMessage("Gider uzunluğu 1-50 karakter arası olmalı");
		}
	}
}
