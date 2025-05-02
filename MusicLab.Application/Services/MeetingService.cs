using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLab.Application.DTO;
using MusicLab.Application.Interfaces.Repositories;
using MusicLab.Application.Interfaces.Services;
using MusicLab.Domain.Entities;
using MusicLab.Domain.Enums;

namespace MusicLab.Application.Services
{
    public class MeetingService(IMeetingRepository meetingRepository) : IMeetingService
    {
        public Meeting Create(CreateMeetingDTO dto)
        {
            //var invitations = dto.MembersId
            //    .Select(id => new Invitation
            //{
            //    MemberId = id,
            //    Availability = Availability.Pending

            //})
            //    .ToList();

            Meeting m = meetingRepository.Add(

                new Meeting
                {
                    Name = dto.Name,
                    Description = dto.Description,
                    Location = dto.Location,
                    StartTime = dto.StartTime,
                    EndTime = dto.EndTime,
                    EventType = dto.EventType,
                    ProjectId = dto.ProjectId,
                    //Project = dto.Project.Select
                    Invitations = dto.MembersId
                        .Select(id => new Invitation
                        {
                            MemberId = id,
                            Availability = Availability.Pending

                        }
                         ).ToList()
                }
                );
            return m;
            
        }

        public List<Meeting> GetMeetingsByMemberId(int memberId)
        {
            return meetingRepository.GetMeetingsByMemberId(memberId);
        }

    }  
}
