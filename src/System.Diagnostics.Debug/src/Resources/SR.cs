// Do not edit this file manually it is auto-generated during the build based on the .resx file for this project.
namespace System
{
    internal static partial class SR
    {
#pragma warning disable 0414
        private const string s_resourcesName = "System.Diagnostics.Debug.resources"; // assembly Name + .resources
#pragma warning restore 0414

#if !DEBUGRESOURCES
        internal static string DebugAssertBanner {
              get { return SR.GetResourceString("DebugAssertBanner", null); }
        }
        internal static string DebugAssertLongMessage {
              get { return SR.GetResourceString("DebugAssertLongMessage", null); }
        }
        internal static string DebugAssertShortMessage {
              get { return SR.GetResourceString("DebugAssertShortMessage", null); }
        }
        internal static string DebugAssertTitle {
              get { return SR.GetResourceString("DebugAssertTitle", null); }
        }
        internal static string DebugAssertTitleShort {
              get { return SR.GetResourceString("DebugAssertTitleShort", null); }
        }
        internal static string IO_FileNotFound {
              get { return SR.GetResourceString("IO_FileNotFound", null); }
        }
        internal static string IO_FileNotFound_FileName {
              get { return SR.GetResourceString("IO_FileNotFound_FileName", null); }
        }
        internal static string IO_PathNotFound_NoPathName {
              get { return SR.GetResourceString("IO_PathNotFound_NoPathName", null); }
        }
        internal static string IO_PathNotFound_Path {
              get { return SR.GetResourceString("IO_PathNotFound_Path", null); }
        }
        internal static string IO_SharingViolation_File {
              get { return SR.GetResourceString("IO_SharingViolation_File", null); }
        }
        internal static string IO_SharingViolation_NoFileName {
              get { return SR.GetResourceString("IO_SharingViolation_NoFileName", null); }
        }
        internal static string UnauthorizedAccess_IODenied_NoPathName {
              get { return SR.GetResourceString("UnauthorizedAccess_IODenied_NoPathName", null); }
        }
        internal static string UnauthorizedAccess_IODenied_Path {
              get { return SR.GetResourceString("UnauthorizedAccess_IODenied_Path", null); }
        }
        internal static string RTL {
              get { return SR.GetResourceString("RTL", null); }
        }
        internal static string ArgumentOutOfRange_FileLengthTooBig {
              get { return SR.GetResourceString("ArgumentOutOfRange_FileLengthTooBig", null); }
        }
        internal static string IO_FileExists_Name {
              get { return SR.GetResourceString("IO_FileExists_Name", null); }
        }
        internal static string IO_PathTooLong {
              get { return SR.GetResourceString("IO_PathTooLong", null); }
        }
#else
        internal static string DebugAssertBanner {
              get { return SR.GetResourceString("DebugAssertBanner", @"---- DEBUG ASSERTION FAILED ----"); }
        }
        internal static string DebugAssertLongMessage {
              get { return SR.GetResourceString("DebugAssertLongMessage", @"---- Assert Long Message ----"); }
        }
        internal static string DebugAssertShortMessage {
              get { return SR.GetResourceString("DebugAssertShortMessage", @"---- Assert Short Message ----"); }
        }
        internal static string DebugAssertTitle {
              get { return SR.GetResourceString("DebugAssertTitle", @"Assertion Failed: Cancel=Debug, OK=Continue"); }
        }
        internal static string DebugAssertTitleShort {
              get { return SR.GetResourceString("DebugAssertTitleShort", @"Assertion Failed"); }
        }
        internal static string IO_FileNotFound {
              get { return SR.GetResourceString("IO_FileNotFound", @"Unable to find the specified file."); }
        }
        internal static string IO_FileNotFound_FileName {
              get { return SR.GetResourceString("IO_FileNotFound_FileName", @"Could not find file '{0}'."); }
        }
        internal static string IO_PathNotFound_NoPathName {
              get { return SR.GetResourceString("IO_PathNotFound_NoPathName", @"Could not find a part of the path."); }
        }
        internal static string IO_PathNotFound_Path {
              get { return SR.GetResourceString("IO_PathNotFound_Path", @"Could not find a part of the path '{0}'."); }
        }
        internal static string IO_SharingViolation_File {
              get { return SR.GetResourceString("IO_SharingViolation_File", @"The process cannot access the file '{0}' because it is being used by another process."); }
        }
        internal static string IO_SharingViolation_NoFileName {
              get { return SR.GetResourceString("IO_SharingViolation_NoFileName", @"The process cannot access the file because it is being used by another process."); }
        }
        internal static string UnauthorizedAccess_IODenied_NoPathName {
              get { return SR.GetResourceString("UnauthorizedAccess_IODenied_NoPathName", @"Access to the path is denied."); }
        }
        internal static string UnauthorizedAccess_IODenied_Path {
              get { return SR.GetResourceString("UnauthorizedAccess_IODenied_Path", @"Access to the path '{0}' is denied."); }
        }
        internal static string RTL {
              get { return SR.GetResourceString("RTL", @"RTL_False"); }
        }
        internal static string ArgumentOutOfRange_FileLengthTooBig {
              get { return SR.GetResourceString("ArgumentOutOfRange_FileLengthTooBig", @"Specified file length was too large for the file system."); }
        }
        internal static string IO_FileExists_Name {
              get { return SR.GetResourceString("IO_FileExists_Name", @"The file '{0}' already exists."); }
        }
        internal static string IO_PathTooLong {
              get { return SR.GetResourceString("IO_PathTooLong", @"The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters."); }
        }

#endif
    }
}
