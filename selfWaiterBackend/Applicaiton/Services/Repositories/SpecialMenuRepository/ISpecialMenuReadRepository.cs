﻿using Core.Persistence.Repositories;
using Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaiton.Services.Repositories.SpecialMenuRepository
{
    public interface ISpecialMenuReadRepository: IReadRepository<SpecialMenu>
    {
    }
}
