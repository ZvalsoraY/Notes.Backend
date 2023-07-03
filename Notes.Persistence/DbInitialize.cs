﻿using Notes.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistence
{
    public class DbInitialize
    {
        public static void Initialize(NotesDbContext context) 
        {
            context.Database.EnsureCreated();
        }
    }
}
