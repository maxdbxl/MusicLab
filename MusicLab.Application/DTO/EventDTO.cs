using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Domain.Entities;
using MusicLab.Domain.Enums;

namespace MusicLab.Application.DTO
{
    public class EventDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public EventType EventType { get; set; }
        public bool IsConfirmed { get; set; }

        public EventDTO(Meeting m)
        {
            Id = m.Id;
            Name = m.Name;
            Description = m.Description;
            Location = m.Location;
            StartDate = m.StartTime;
            EndDate = m.EndTime;
            EventType = m.EventType;
            IsConfirmed = true;
        }

        public EventDTO(PersonalEvent pe) {
            Id = pe.Id;
            Name = pe.Name;
            Description = pe.Description;
            Location = pe.Location;
            StartDate = pe.StartTime;
            EndDate = pe.EndTime;
            EventType = pe.EventType;
            IsConfirmed = true;
        }
    }
}
