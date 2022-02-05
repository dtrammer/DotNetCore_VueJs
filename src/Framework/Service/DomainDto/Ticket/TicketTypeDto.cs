﻿namespace Service.DomainDto.Ticket;

public record class TicketTypeDto : IDto
{
    public int Id { get; init; }

    public string Type { get; init; } = null!;
}
