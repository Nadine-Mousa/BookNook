﻿using BookNook.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookNook.DataAccess.Repository.IRepository
{
    public interface IRepositoryCategory : IRepository<Category>
    {
    }
}
