﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mapster;

using MediatR;

using Sample_CleanArchitecture_CQRS.Application.Common.Models.Results;
using Sample_CleanArchitecture_CQRS.Application.CQRS.Products.Common;

namespace Sample_CleanArchitecture_CQRS.Application.CQRS.Products.Commands.Edit;


public sealed record EditProductCommand(
    Guid ProductId,
    string? Name,
    decimal? Price) : IRequest<ApiResult<ProductDetailsDto>>, IMapFrom<EditProductDto>;

public sealed record EditProductDto(
    string? Name,
    decimal? Price);

