using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsTemplate
{
    public enum NotificationType
    {
        Success,
        Error,
        Info
    }

    public class Notification
    {
        public Notification(string message, NotificationType type)
        {
            Message = message;
            Type = type;
        }

        public string Message
        {
            get; set;
        }

        public NotificationType Type
        {
            get; set;
        }

        public Color Color
        {
            get
            {
                switch (Type)
                {
                    case (NotificationType.Success):
                        return Color.PaleGreen;

                    case (NotificationType.Error):
                        return Color.IndianRed;

                    default:
                        return Color.PaleTurquoise;
                }
            }
        }

        public Bitmap Image
        {
            get
            {
                switch (Type)
                {
                    case (NotificationType.Success):
                        return Properties.Resources.check_64;

                    case (NotificationType.Error):
                        return Properties.Resources.error_64;

                    default:
                        return Properties.Resources.info_64;
                }
            }
        }

        public static Notification Success(string message)
        {
            return new Notification(message, NotificationType.Success);
        }

        public static Notification Error(string message)
        {
            return new Notification(message, NotificationType.Error);
        }

        public static Notification Info(string message)
        {
            return new Notification(message, NotificationType.Info);
        }
    }
}