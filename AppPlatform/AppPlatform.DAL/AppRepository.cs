﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPlatform.IDAL;
using AppPlatform.Model.Models;

namespace AppPlatform.DAL
{
    public class AppRepository : BaseRepository<App>,IAppRepository
    {
    }
}
