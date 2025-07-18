﻿using FoxmindEd_Learning.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoxmindEd_Learning.API.Infrastructure.DbContexts;

public class FE_DbContext(
    DbContextOptions<FE_DbContext> options) : DbContext(options)
{
    public DbSet<ExampleEntity> ExampleEntities { get; set; }
}
