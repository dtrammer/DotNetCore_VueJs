﻿namespace Service.Domain.Roles.Models;

public record class RoleCreateUpdateViewModel : ICreateViewModel, IUpdateViewModel
{
    public string Name { get; init; } = null!;

    public string Description { get; init; } = null!;
}

public class RoleCreateUpdateViewModelValidator : BaseValidator<RoleCreateUpdateViewModel>
{
    public RoleCreateUpdateViewModelValidator()
    {
        RuleFor(p => p.Name).NotEmpty().MaximumLength(15);

        RuleFor(p => p.Description).NotEmpty().MaximumLength(100);
    }
}
