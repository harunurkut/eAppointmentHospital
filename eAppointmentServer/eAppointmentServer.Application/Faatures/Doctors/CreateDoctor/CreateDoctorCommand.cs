using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Faatures.Doctors.CreateDoctor;

public sealed record CreateDoctorCommand(
    string FirstName,
    string LastName,
    int DepartmentValue) : IRequest<Result<string>>;
