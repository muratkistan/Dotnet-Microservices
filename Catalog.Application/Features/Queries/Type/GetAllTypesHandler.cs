using AutoMapper;
using Catalog.Application.Dtos;
using Catalog.Application.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Queries.Type
{
    public class GetAllTypesHandler : IRequestHandler<GetAllTypesQuery, IList<TypeResponse>>
    {
        private readonly ITypeRepository _typesRepository;
        private readonly IMapper _mapper;

        public GetAllTypesHandler(ITypeRepository typesRepository, IMapper mapper)
        {
            _typesRepository = typesRepository;
            _mapper = mapper;
        }

        public async Task<IList<TypeResponse>> Handle(GetAllTypesQuery request, CancellationToken cancellationToken)
        {
            var typesList = await _typesRepository.GetAllTypes();
            var typesResponseList = _mapper.Map<IList<TypeResponse>>(typesList);
            return typesResponseList;
        }
    }
}