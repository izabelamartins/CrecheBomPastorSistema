﻿using CrecheBomPastor.Domain.Entities;
using CrecheBomPastor.Domain.Interfaces;

namespace CrecheBomPastor.Infra.Data.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
    }
}