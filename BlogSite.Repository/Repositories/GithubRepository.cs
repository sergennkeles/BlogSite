﻿using BlogSite.Core.Entities;
using BlogSite.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Repository.Repositories
{
    public class GithubRepository : GenericRepository<Github>, IGithubRepository
    {
        public GithubRepository(AppDbContext context, DbSet<Github> dbSet) : base(context, dbSet)
        {
        }
    }
}
