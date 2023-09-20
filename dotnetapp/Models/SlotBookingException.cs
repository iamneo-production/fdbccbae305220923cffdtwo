namespace dotnetapp.Exceptions
{
    public class SlotBookingException    
    {
        public string SlotBookingExceptionMessage { get; set; }

        public static readonly string SLOT_IS_FULL = "Slot is full.";
        public static readonly string YOU_HAVE_ALREADY_BOOKED_THIS_SLOT = "You have already booked this slot."; 
    }
}