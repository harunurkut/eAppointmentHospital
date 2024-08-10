using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Faatures.Doctors.DeleteDoctorById;

public sealed record DeleteDoctorByIdCommand(Guid Id) : IRequest<Result<string>>;


