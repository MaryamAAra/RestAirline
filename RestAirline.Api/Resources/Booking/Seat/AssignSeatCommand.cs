﻿using System;
using RestAirline.Domain.Booking;
using Microsoft.AspNetCore.Mvc;
using RestAirline.Api.Controllers;
using RestAirline.Api.Hypermedia;

namespace RestAirline.Api.Resources.Booking.Seat
{
    public class AssignSeatCommand : HypermediaCommand<SeatAssignmentResource>
    {
        [Obsolete("For serialization")]
        public AssignSeatCommand() { }


        public AssignSeatCommand(IUrlHelper urlHelper) : base(urlHelper.Link((BookingController c) => c.AssignSeat(null)))
        {

        }

        public Guid BookingId { get; set; }
        public Domain.Shared.Seat Seat { get; set; }
        public Passenger Passenger { get; set; }
    }
}