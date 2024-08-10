using eAppointmentServer.Domain.Entities;
using MediatR;
using TS.Result;

namespace eAppointmentServer.Application.Faatures.Doctors.GetAllDoctor
{
    public sealed record GetAllDoctorQuery() : IRequest<Result<List<Doctor>>>;
}
