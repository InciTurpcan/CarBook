﻿using CarBook_Application.Features.Mediator.Results.StatisticsResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook_Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountByElectricQuery : IRequest<GetCarCountByElectricQueryResult>
    {
    }
}
