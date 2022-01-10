VB.NET Demo using ADO.NET with a DataSet Object and Synergy/DE Connectivity Series
==================================================================================

Author
======
Blair Varley
Synergex (www.synergex.com)
blairvarley@synergex.com

Disclaimer
==========
This software is provided "as is" and without warranty. Synergex accepts no responsibility for any loss or damage, which may result from the use of this software.

Introduction
============
This example includes a Visual Studio .NET 2003 Visual Basic solution called "xfODBC_V2", which enables you to view records in the CUSTOMERS table of the sample database (distributed with Connectivity Series).

This solution uses ADO.NET and a DataSet object.  The DataSet object uses a copy of the data in memory, disconnected from the data source.

Requirements
============
* Visual Studio .NET 2003 with Visual Basic .NET and .NET Framework 1.1 with Service Pack 1.  The service pack includes Microsoft Hotfix Q833050 for Windows 2000/XP and Q833742 for Windows 2003, which are needed to work with Connectivity Series.
* Synergy/DE version 8.1.7 (or higher) with Connectivity Series
* MDAC 2.8 or higher

Instructions
============
1.  If it is not already installed, install Synergy/DE version 8.1.7 or higher.  Be sure to select Connectivity Series.

2.  Make sure the SODBC_ODBCNAME environment variable is NOT set.

3.  Generate system catalogs for the sample database.  Follow the instructions in chapter 2 ("Using the Sample Database as a Tutorial") of the xfODBC User's Guide.  Note that xfODBC_V2 uses the following:
    --  The sodbc_sa connect file as distributed
    --  The DBADMIN user (with the password "MANAGER")
    --  The sample DSN (xfODBC) as distributed

4.  Open the xfODBC_V2.sln file in Visual Studio .NET 2003 Development Environment.

5.  Build the solution and run it from Visual Studio .NET 2003 on a local drive (not a mapped drive).

The application has four navigation buttons you can use to see the records in the sample database's CUSTOMERS table.  These buttons are "First Record", "Next Record", "Previous Record", and "Last Record".  Also, the application has four other buttons that enable you to add, delete, edit and save records in the sample database's CUSTOMERS table.

To view the source code, open "frmMain.vb" in Visual Studio, and select View Code.
