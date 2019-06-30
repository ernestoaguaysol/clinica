using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppVet.SharedKernel
{
    public enum TypeDocument
    {
        DNI = 0,
        Other = 1
    }
    public enum Gender
    {
        Female = 1,
        Male = 2
    }

    public enum RoomType
    {
        OfficeRoom = 0,
        OperationRoom = 1,
        Lab = 2
    }

    public enum DoctorType
    {
        Veterinarian = 0,
        Surgeon = 1,
        Assistant = 2,
        Other = 3
    }

    public enum ServiceType
    {
        Surgery = 0,
        MedicalConsultation = 1,
        Vaccination = 2,
        Other = 3
    }

    public enum AppointmentState
    {
        Active = 0,
        Canceled = 1
    }

    public enum BillingType
    {
        A = 0,
        B = 1,
        C = 2,
        Other = 3
    }

    public enum TrackingState
    {
        Unchanged = 0,
        Added = 1,
        Modified = 2,
        Deleted = 3
    }
}