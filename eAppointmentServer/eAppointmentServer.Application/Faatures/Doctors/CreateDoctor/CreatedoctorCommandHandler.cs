using AutoMapper;
using eAppointmentServer.Domain.Entities;
using eAppointmentServer.Domain.Repositories;
using GenericRepository;
using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Faatures.Doctors.CreateDoctor;

internal sealed class CreatedoctorCommandHandler(
    IDoctorRepository doctorRepository, 
    IUnitOfWork unitOfWork,
    IMapper mapper) : IRequestHandler<CreateDoctorCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
    {
        //Doctor doctor = new()
        //{
        //    FirstName=request.FirstName,
        //    LastName=request.LastName,
        //    Department=DepartmentEnum.FromValue(request.Department)
        //};
        Doctor doctor = mapper.Map<Doctor>(request);

        await doctorRepository.AddAsync(doctor,cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Doctor cretae is succefull";
       
    }
}
