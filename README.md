# MDS Help Desk

Windows Forms (VB.NET) replacement for the Access help desk front end
(`1000-HelpDesk.accdb`). It works directly against the existing SQL Server tables
on `prd-v-sql-01` (`MDS.dbo.MDS_HelpDesk*`, plus lookups in `DC00MDS`).

## Build

Open `MDS_Help Desk.slnx` in Visual Studio 2026, or run `dotnet build`.

## Configuration

`MDS_Help Desk/appsettings.json` holds the connection strings (Windows authentication,
no passwords), the IT support email address and the Database Mail profile.

## What is converted

- Main menu: Add Ticket, Edit Tickets, Print Tickets, Knowledge Base, IT Admin, Exit
- Reports: open tickets, single ticket (Quick Print), ticket counts, knowledge base,
  computer and printer inventory
- IT Admin: Computers, Printers, Categories, Cadence Unit IDs, Orders Stuck in COMP

Not converted yet: the Utilities menu and the WMS tools on the IT Admin menu.
