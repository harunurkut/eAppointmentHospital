using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Faatures.Doctors.UpdateDoctor;

public sealed record UpdateDoctorCommand(
    Guid Id,
    string FirstName,
    string LastName,
    int DepartmentValue) : IRequest<Result<string>>;
