using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace GloboTicket.TicketManagement.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsCvs(List<EventExportDto> eventExportDtos);
    }
}