USE [master]
GO
/****** Object:  Database [GroupStudy]    Script Date: 01-Jul-23 6:10:11 PM ******/
CREATE DATABASE [GroupStudy]
GO
USE [GroupStudy]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 01-Jul-23 6:10:11 PM ******/

CREATE TABLE [dbo].[Comment](
	[commentId] [int] IDENTITY(1,1) NOT NULL,
	[groupID] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[comment] [text] NOT NULL,
 CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED 
(
	[commentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 01-Jul-23 6:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[groupId] [int] IDENTITY(1,1) NOT NULL,
	[subjectId] [varchar](10) NOT NULL,
	[size] [int] NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[groupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Participant]    Script Date: 01-Jul-23 6:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Participant](
	[userId] [int] NOT NULL,
	[groupId] [int] NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_Participant] PRIMARY KEY CLUSTERED 
(
	[userId] ASC,
	[groupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Progress]    Script Date: 01-Jul-23 6:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Progress](
	[userId] [int] NOT NULL,
	[slotId] [int] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Progress] PRIMARY KEY CLUSTERED 
(
	[userId] ASC,
	[slotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 01-Jul-23 6:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [varchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slot]    Script Date: 01-Jul-23 6:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slot](
	[slotId] [int] IDENTITY(1,1) NOT NULL,
	[groupId] [int] NULL,
	[slotIndex] [varchar](50) NULL,
	[slotName] [varchar](50) NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Slot] PRIMARY KEY CLUSTERED 
(
	[slotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudyMaterial]    Script Date: 01-Jul-23 6:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudyMaterial](
	[studyMaterialID] [int] IDENTITY(1,1) NOT NULL,
	[slotId] [int] NULL,
	[title] [varchar](50) NULL,
	[content] [text] NULL,
	[link] [varchar](100) NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_StudyMaterial] PRIMARY KEY CLUSTERED 
(
	[studyMaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 01-Jul-23 6:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[subjectId] [varchar](10) NOT NULL,
	[subjectName] [varchar](50) NULL,
	[description] [text] NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[subjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 01-Jul-23 6:10:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[birthday] [date] NULL,
	[address] [varchar](50) NULL,
	[roleId] [int] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([commentId], [groupID], [userId], [comment]) VALUES (1, 1, 1, N'bai nay lam sao')
INSERT [dbo].[Comment] ([commentId], [groupID], [userId], [comment]) VALUES (2, 1, 2, N'hong biet nua')
INSERT [dbo].[Comment] ([commentId], [groupID], [userId], [comment]) VALUES (4, 1, 5, N'hihi')
INSERT [dbo].[Comment] ([commentId], [groupID], [userId], [comment]) VALUES (5, 1, 5, N'123')
INSERT [dbo].[Comment] ([commentId], [groupID], [userId], [comment]) VALUES (9, 1, 5, N'11')
SET IDENTITY_INSERT [dbo].[Comment] OFF
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (1, N'PRJ301', 10, 1)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (2, N'PRN211', 6, 0)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (3, N'DBI202', 22, 1)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (4, N'PRJ301', 5, 0)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (5, N'PRJ301', 16, 1)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (6, N'PRN211', 8, 1)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (9, N'SWR302', 66, 1)
INSERT [dbo].[Group] ([groupId], [subjectId], [size], [status]) VALUES (10, N'SWP391', 25, 1)
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (1, 1, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (1, 2, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (1, 4, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (1, 5, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (2, 1, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (2, 3, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (3, 2, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (3, 3, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (3, 5, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (4, 2, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (4, 4, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (4, 5, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (5, 1, 1)
INSERT [dbo].[Participant] ([userId], [groupId], [status]) VALUES (5, 2, 0)
GO
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (2, 1, 1)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (2, 2, 1)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (2, 3, 1)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (2, 4, 0)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (2, 5, 0)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (2, 6, 1)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (2, 7, 0)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (2, 8, 0)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (5, 1, 1)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (5, 2, 1)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (5, 3, 0)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (5, 4, 0)
INSERT [dbo].[Progress] ([userId], [slotId], [status]) VALUES (5, 5, 0)
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([roleId], [roleName]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([roleId], [roleName]) VALUES (2, N'Student')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Slot] ON 

INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (1, 1, N'1', N'Basic Web Application, Servlet', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (2, 1, N'2', N'JDBC', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (3, 1, N'3', N'Java Server Pages', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (4, 1, N'4', N'MVC-Architecture', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (5, 1, N'5', N'Sesssion Management', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (6, 3, N'1', N'The Worlds of Database Systems', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (7, 3, N'2', N'The Relational Model of Data', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (8, 3, N'3', N'Design Theory for Relational Databases', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (9, 6, N'1', N'Introduction to .NET Platform _ Visual Studio.NET', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (10, 6, N'2', N'C# Programming', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (11, 6, N'3', N'Collections and Generics', 1)
INSERT [dbo].[Slot] ([slotId], [groupId], [slotIndex], [slotName], [status]) VALUES (12, 6, N'4', N'Delegate , Event _ LINQ', 1)
SET IDENTITY_INSERT [dbo].[Slot] OFF
GO
SET IDENTITY_INSERT [dbo].[StudyMaterial] ON 

INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (1, 1, N'What is HTML? ', N'HTML is a language for describing web pages.
HTML stands for Hyper Text Markup Language.
HTML is not a programming language, it is a markup language.
A markup language is a set of markup tags.
HTML uses markup tags to describe web pages.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (2, 1, N'HTML Tags', N'HTML markup tags are usually called HTML tags: HTML tags are keywords surrounded by angle brackets like <html>.
HTML tags normally come in pairs like <b> and </b>.
The first tag in a pair is the start tag, the second tag is the end tag.
Start and end tags are also called opening tags and closing tags.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (3, 1, N'HTML Documents = Web Pages ', N'HTML documents describe web pages. 
HTML documents contain. HTML tags and plain text.
HTML documents are also called web pages.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (4, 1, N'Web browser', N'The purpose of a web browser (like Internet Explorer or Firefox) is to read HTML documents and display them as web pages. The browser does not display the HTML tags, but uses the tags to interpret the content of the page.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (5, 1, N'What is a Servlet ?', N'Servlets are small Java programs that run on a Web server and help to build dynamic Web pages. Servlets receive and respond to requests from Web clients, usually across HTTP, the HyperText Transfer Protocol. Java Servlet technology was created as a portable way to provide dynamic, user-oriented content. ', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (6, 1, N'HTTP Requests', N'An HTTP request consists of 
a request method 
a request URL 
header fields 
body.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (7, 1, N'HTTP Method', N'GET - retrieves the resource identified by the request URL. 
HEAD - returns the headers identified by the request URL. 
POST - sends data of unlimited length to the web server. 
PUT - stores a resource under the request URL. 
DELETE - removes the resource identified by the request URL. 
OPTIONS - returns the HTTP methods the server supports. 
TRACE - returns the header fields sent with the TRACE request.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (8, 2, N'Database and DBMS', N'Database is a collection of related data which are stored in secondary mass storage and are used by some processes concurrently.
Databases are organized in some ways in order to reduce redundancies.
DBMS: Database management system is a software which manages some databases. It supports ways to users/processes for creating, updating, manipulating on databases and security mechanisms are supported also. 
DBMS libraries (C/C++ codes are usually used) support APIs for user programs to manipulate databases.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (9, 2, N'Relational Database Overview', N'Common databases are designed and implemented based on relational algebra (set theory).
Relational database is one that presents information in tables with rows and columns.
A table is referred to as a relation in the sense that it is a collection of objects of the same type (rows). 
A Relational Database Management System (RDBMS)- such as MS Access, MS SQL Server, Oracle- handles the way data is stored, maintained, and retrieved.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (10, 2, N'Common DML queries:
', N'SELECT columns FROM tables WHERE condition
UPDATE table SET column=value,… Where condition
DELETE FROM table WHERE condition 
INSERT INTO table Values ( val1, val2,…)
INSERT INTO table (col1, col2,…) Values ( val1, val2,…)', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (11, 2, N'3-JDBC and JDBC Driver', N'The JDBC™ API was designed to keep simple things simple. This means that the JDBC makes everyday database tasks easy. This trail walks you through examples of using JDBC to execute common SQL statements, and perform other objectives common to database applications. 
The JDBC API is a Java API that can access any kind of tabular data, especially data stored in a Relational Database. 
DBMS provider/developer will supply a package in which specific classes implementing standard JDBC driver (free).
Based on characteristics of DBMSs, four types of JDBC drivers are:
Type 1: JDBC ODBC
Type 2: Native API
Type 3: Network Protocol 
Type 4: Native Protocol
Type 1 and Type 4 are populated.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (12, 2, N'Type 1-Driver : JDBC-ODBC', N'This package is in the JDK as default.
Translates JDBC APIs to ODBC APIs 
Enables the Java applications to interact with any database supported by Microsoft.
Provides platform dependence, as JDBC ODBC bridge driver uses ODBC
JDBC-ODBC bridge is useful when Java driver is not available for a database but it is supported by Microsoft.
Disadvantages
Platform dependence (Microsoft)
The performance is comparatively slower than other drivers
Require the ODBC driver and the client DB to be on the server.
Usage: DSN is registered to use connecting DB (a data source is declared in Control Panel/ODBC Data sources)  ', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (13, 2, N'Type 2-Driver: Native API', N'Provides access to the database through C/C++ codes.
Developed using native code libraries
Native code libraries provide access to the database, and improve the performance
Java application sends a request for database connectivity as a normal JDBC call to the Native API driver
Establishes the call, and translates the call to the particular database protocol that is forwarded to the database', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (14, 2, N'Type 3-Driver: Network Protocol', N'Use a pure Java client and communicate with a middleware server using a database-independent protocol. 
The middleware server then communicates the client’s requests to the data source
Manages multiple Java applications connecting to different databases', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (15, 2, N'Type 4-Driver: Native Protocol', N'Communicates directly with the database using Java sockets
Improves the performance as translation is not required
Converts JDBC queries into native calls used by the particular RDBMS
The driver library is required when it is used and attached with the deployed application (sqlserver 2000: mssqlserver.jar, msutil.jar, msbase.jar; sqlserver 2005: sqljdbc.jar; jtds: jtds.jar …)
Independent platform', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (16, 3, N'Java Server Pages (JSP)
', N'What JSP Technology is and how you can use it.
JSP Page
Translation Time
How JSP Works?
JSP Elements
JSP Predefined Variable – Implicit Objects
JSP Lifecycle', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (17, 3, N'What JSP Technology is and how you can use it. 
', N'JavaServer Pages (JSP) technology provides a simplified, fast way to create web pages that display dynamically-generated content.
The JSP 1.2 specification is an important part of the Java 2 Platform, Enterprise Edition. Using JSP and Enterprise  JavaBeans technologies together is a great way to implement distributed enterprise applications with web-based front ends.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (18, 3, N'JSP Page', N'A JSP page is a page created by the web developer that includes JSP technology-specific tags, declarations, and possibly scriptlets, in combination with other static HTML or XML tags.
A JSP page has the extension .jsp; this signals to the web server that the JSP engine will process elements on this page. 
Pages built using JSP technology are typically implemented using a translation phase that is performed once, the first time the page is called. The page is compiled into a Java Servlet class and remains in server memory, so subsequent calls to the page have very fast response times.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (19, 3, N'JSP Elements', N'Declarations
<%! code %>
Expressions
<%= expression%>
Scriplets
<% code %>', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (20, 3, N'JSP Predefined Variable – Implicit Objects', N'request – Object of HttpServletRequest (request parameters, HTTP headers, cookies
response – Object of HttpServletResponse
out - Object of PrintWriter buffered version JspWriter
session - Object of HttpSession associated with the request
application - Object of ServletContext shared by all servlets in the engine
config - Object of ServletConfig
pageContext - Object of PageContext in JSP for a single point of access
page – variable synonym for this object', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (21, 3, N'JSP Directives', N'Directives, which—like scripting elements—are pieces of JSP tag-like syntax. Like an XML or HTML tag, directives have attributes that dictate their meaning and effect. In almost all cases, the effects produced by directives can’t be replicated using expressions, scriptlets, or declarations.
We’ll consider the three directives: 
page, include, and taglib.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (22, 4, N'What is MVC', N'Model–view–controller (usually known as MVC) is a software design pattern commonly used for developing user interfaces that divide the related program logic into three interconnected elements.
MVC proposes the construction of three distinct components. One side for the representation of information, and on the other hand for user interaction
Model : The central component of the pattern. It is the application''s dynamic data structure, independent of the user interface. It directly manages the data, logic, and rules of the application.
View : Any representation of information such as a chart, diagram, or table. Multiple views of the same information are possible, such as a bar chart for management and a tabular view for accountants.
Controller: Accepts input and converts it to commands for the model or view.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (23, 4, N'The Model', N'It is the specific representation of the information with which the system operates. Logic ensures the integrity of data and allows to derive it.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (24, 4, N'The View', N'Represents the model in a suitable format to interact and access the data, usually call “User Interface” (GUI Java, HTML, XML)', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (25, 4, N'The Controller', N'It is the link between the view and the model, is responsible for receiving and responding to events, typically user actions invokes changes on the model and probably in the view', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (26, 4, N'MVC1 and MVC2', N'MVC1:
	Servlet and JSP are the main technology to develop the web application
	Pros: Easy and Quick to develop web application
	Cons: 
		Navigation control is decentralized 
		Time consuming for custom JSP tag
		Hard to extend
MVC2:
	Base on MVC design pattern which consist of three modules model, view, and controller
	Pros:
		Navigation control is centralized
		Easy to maintain
		Easy to extend
		Easy to test
		Better separation of concerns
	Cons:
		We need to write the controller code self. If we change the controller code, we need to recompile the class and redeploy the application.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (27, 4, N'Benefits', N'Organization
Rapid Application Development
Reusing Code
Parallel development
It represent the same information in different ways
The views and application behavior should reflect the manipulations of the data immediately
It allow different user interface standards or port it to other environments where the application code should not be affected.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (28, 5, N'Web Container Model', N'The servlet container is a compiled, executable program. The container is the intermediary between the Web server and the servlets in the container. 
The container loads, initializes, and executes the servlets. When a request arrives, the container maps the request to a servlet, translates the request, and then passes the request to the servlet. The servlet processes the request and produces a response. The container translates the response into the network format, then sends the response back to the Web server.
The servlet container is a compiled, executable program. The container is the intermediary between the Web server and the servlets in the container. 
The container loads, initializes, and executes the servlets. When a request arrives, the container maps the request to a servlet, translates the request, and then passes the request to the servlet. The servlet processes the request and produces a response. The container translates the response into the network format, then sends the response back to the Web server.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (29, 5, N'Servlet Context', N'A servlet container can manage any number of distinct applications. An application consists of any number of servlets, filters, listeners, and static Web pages. A set of components working together is a Web application. 
The container uses a context to group related components. The container loads the objects within a context as a group, and objects within the same context can easily share data. 
Each context usually corresponds to a distinct Web application.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (30, 5, N'Servlet Context Initialization Parameters', N'ServletContext sc = getServletContext();
String database = sc.getInitParameter("machineName");
String secret = sc.getInitParameter("secretParameterFile");', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (31, 5, N'Session Death', N'HttpSession.invalidate()  : Invalidates this session then unbinds any objects bound to it.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (32, 5, N'Session Management', N'There are two principal methods for session management “officially” recognized by the servlet API. One method is management by cookie exchange, and the other is management by rewriting URLs.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (33, 6, N'The Evolution of Database systems', N'Database
	A collection of information that exists over a long period of time.
	A collection of related data.
	Managed by a DBMS
Database Management System (DBMS)
	A software package/system to facilitate the creation and maintenance of a computerized database
Database System
	The DBMS software together with the data itself. Sometimes, the applications are also included.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (34, 6, N'Overview of DBMS', N'Database Management System
	DBMS components
	Database Users
	Database language
	Relational databases
DBMS components
	Single box: system component
	Double box: memory data structure
	Solid line: control & data flow
	Dashed line: data flow only
Database Users
 	Database Administrators, authorize access to database, coordinate, monitor its use, acquiring software, and hardware resources,
	Database Designers, define the content, the structure, the constraints, and functions or transactions against the database
	Database End users, use data for queries, reports and some of them actually update the database content', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (35, 6, N'DDL - Data Definition Language Commands
', N'DBA needs special authority to execute schema-altering commands
Schema-altering commands are known as DDL commands, and used for defining data structure
These commands are parsed by a DDL compiler and passed to the execution engine, then goes through the index/file/record manager to alter the metadata (schema information for the database)
Examples: CREATE, ALTER, DROP', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (36, 6, N'DML - Data Manipulation Language Commands
', N'Are used by computer programs or DB users to retrieve, insert, delete, and update data
Not affect the schema of the database, but affect the content of the database or extract data from database
DML has two separate subsystems
	Answering the query
	Transaction processing', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (37, 6, N'Transaction properties: 4 properties - ACID
', N'“A” – atomic, all-or-nothing execution of transactions
“I” – isolation, each transaction must appear to be executed as if no other transaction is executing at the same time ? concurrency control, locking need
“D” – durability, the condition that the effect on the database of a transaction must never be lost, once the transaction has completed. ? logging need
“C” – consistency, all databases have consistency constrains', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (38, 7, N'The Relational Model in Brief', N'The relational model is based on tables
	Relation’s name
	Attributes (column headers)
	Tuples (rows)
The operations associated with the relational model form the relational algebra
The constraints on relational model define limitations on what the data can be on tables', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (39, 7, N'The Semi-structured Model in Brief', N'Semi-structured data resembles trees or graphs rather than tables or arrays
XML, a way to represent data by hierarchically nested tagged elements
Operations involve following paths in tree from an element to one or more of its nested sub elements, and so on
Constraints involve the data type of values associated with a nested tag', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (40, 7, N'Basics of the Relational Model', N'The relational model represents data as a 2-dimensional table called a relation
	Suppose relation named as Movies
	Each row represents a movie
	Each column represents a property of movie
Attributes
 	A columns of a relation
	Appears at the top of the columns
Relation schema
	Relation’s name
	Set of attributes for this relation
	I.e. Movies (title, year, length, genre)
Database schema
	Set of schemas for the relations of a database
Tuples
	The rows of a relation, excepted the header row
	A tuple has one component for each attribute of the relation', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (41, 7, N'Summary 1: Relational Model', N'Relation schema: relation_name(<list of attributes>) (relation name + attribute names + attribute types)
Relation instance: current set of rows for a relation schema. Each row is also called a tuple
Database schema: collection of relation schemas
Database instance:  all relation instances for every relation in the database schema.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (42, 7, N'Why relations?', N'Very simple model
Often a good match for the way we think about our data
Abstract model that underlies SQL, the most important language in DBMS today', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (43, 8, N'Functional Dependency', N'A functional dependency: constraint between two sets of attributes in a relation
A set of attributes X (include A1A2…An) in R functionally determine another attribute Y (include B1B2…Bm), also in R, (written X ? Y) if and only if each X value is associated with precisely one Y value
A functional dependency A1A2…An -> B1B2…Bm holds on relation R if two tuples of R agree on all of the attributes A1, A2, …, An then they must also agree on all of the attributes B1, B2, …, Bm', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (44, 8, N'Superkeys', N'A set of attributes that contains a key is called a superkey
Every superkey satisfies the first condition of a key: it functionally determines all other attributes of the relation
A key is also a super key', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (45, 8, N'Splitting and Combining Rules', N'Splitting Rule
We can replace an FD A1A2…An -> B1B2…Bm by a set of FD’s A1A2…An -> Bi, for i=1,2,…,m
Combining Rule
We can replace a set of FD’s A1A2…An -> Bi, for i=1,2,…,m by the single FD A1A2…An -> B1B2…Bm', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (46, 9, N'Introduction to .NET Framework', N'Microsoft .NET Framework 1.0 was released Feb 13,  2002 is the original implementation of .NET
Developed and run-on Windows platform only
Closed
It supports ASP.NET Web Forms, WinForms, WCF, Silverlight, WPF, LINQ, ADO.NET Entity Framework, Parallel LINQ, Task Parallel Library, etc
The .NET Framework 4.8 version was released on April 18, 2019', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (47, 9, N'The .NET Framework Architecture', N'Common Language Runtime (CLR)
	Is a backbone of .NET Framework
	Performs various functions such as: 
		Memory management,  Code execution
		Error handling, Code safety verification
		Garbage collection(GC)
.NET Framework Class Library (FCL)
	Is a comprehensive object-oriented collection of reusable types. 
	Used to develop applications ranging from traditional command-line to GUI applications that can be used on the Web.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (48, 9, N'Common Language Runtime(CLR)', N'A common runtime for all .NET languages
	Common type system
	Common metadata
	Intermediate Language (IL) to native code compilers
	Memory allocation and garbage collection
	Code execution and security
Over 20 languages supported today
	C#, VB, Jscript, Visual C++ from Microsoft
	Perl, Python, Smalltalk, Cobol, Haskell, Mercury, Eiffel, Oberon, Oz, Pascal, APL, CAML, Scheme, etc.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (49, 9, N'Advantages of CLR', N'Interoperation between managed code and  unmanaged code (COM, DLLs)
Managed code environment
Improved memory handling
JIT(Just-In-Time) Compiler allows code to run in a protected environment as managed code
JIT allows the IL code to be hardware independent
CLR also allows for enforcement of code access security
Verification of type safety
Access to Metadata (enhanced Type Information)', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (50, 9, N'Common Type System (CTS)', N'The common type system defines how types are declared, used, and managed in the common language runtime, and is also an important part of the runtime''s support for cross-language integration. The common type system performs the following functions:
	Establishes a framework that helps enable cross-language integration, type safety, and high-performance code execution
	Provides an object-oriented model that supports the complete implementation of many programming languages
	Defines rules that languages must follow, which helps ensure that objects written in different languages can interact with each other
	Provides a library that contains the primitive data types (such as Boolean, Byte, Char, Int32, and UInt64) used in application development', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (51, 10, N'Introduction to C#
', N'C# is an object-oriented, component-oriented programming language
C# provides language constructs to directly support these concepts, making C# a natural language in which to create and use software components
Several C# features help create robust and durable applications:
	Garbage collection automatically reclaims memory occupied by unreachable unused objects
	Exception handling provides a structured and extensible approach to error detection and recovery
	Lambda expressions support functional programming techniques. Language Integrated Query (LINQ) syntax creates a common pattern for working with data from any source. Language support for asynchronous operations provides syntax for building distributed systems and so on', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (52, 10, N'Namespaces in C#', N'To define a namespace in C#, we will use the namespace keyword followed by the name of the namespace and curly braces containing the body of the namespace as follows', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (53, 10, N'Value Types and Reference types', N'Value types derive from System.ValueType, which derives from System.Object. Types that derive from System.ValueType have special behavior in the CLR(Common Language Runtime). 
	There are two categories of value types: struct and enum
Reference type: A type that is defined as a class, delegate, array, or interface is a reference type. 
	At run time, when declare a variable of a reference type, the variable contains the value null until you explicitly create an object by using the new operator, or assign it an object that has been created elsewhere by using new', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (54, 10, N'Boxing and Unboxing', N'Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type. When the common language runtime (CLR) boxes a value type, it wraps the value inside a System.Object instance and stores it on the managed heap.
Unboxing is an explicit conversion from the type object to a value type or from an interface type to a value type that implements the interface 
An unboxing operation consists of: Checking the object instance to make sure that it is a boxed value of the given value type and Copying the value from the instance into the value-type variable.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (55, 10, N'var keyword', N'The var keyword can be used in place of specifying a specific data type (such as int, bool, or string) and the compiler will automatically infer the underlying data type based on the initial value used to initialize the local data point.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (56, 10, N'dynamic type', N'The dynamic type is a static type, the compiler does not check the type of the dynamic type variable at compile time, instead of this, the compiler gets the type at the run time
In most of the cases, the dynamic type behaves like object types
The dynamic type changes its type at the run time based on the value present on the right-hand side
To get the actual type of the dynamic variable at runtime by using GetType() method
Can pass a dynamic type parameter in the method so that the method can accept any type of parameter at run time', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (57, 11, N'Object-Oriented Programming(OOP)
', N'Programming languages are based on two fundamental concepts: data and ways to manipulate data. This approach had several drawbacks such as lack of re-use and lack of maintainability
To overcome these difficulties, OOP was introduced, which focused on data rather than the ways to manipulate data
The object-oriented approach defines objects as entities having a defined set of values and a defined set of operations that can be performed on these values
Abstraction, encapsulation, polymorphism, and inheritance are the core principles of object-oriented programming', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (58, 11, N'Classes and Objects
', N'A class is a user-defined blueprint or prototype from which objects are created. Basically, a class combines the fields and methods(member function which defines actions) into a single unit.
An object is an instance of the class and represents a real-life entity. To initialize an object in C#, we use a new keyword followed by the name of the class that the object will be based on.', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (59, 11, N'Member Visibility
', N'There are five access specifiers: private, public, protected, internal, and protected internal. By default, the members are private to the class
	public: The type or member can be accessed by any other code in the same assembly or another assembly that references it
	private: The type or member can be accessed only by code in the same class or struct
	protected: The type or member can be accessed only by code in the same class, or in a class that is derived from that class
	internal: The type or member can be accessed by any code in the same assembly, but not from another assembly
	protected internal: The type or member can be accessed by any code in the assembly in which it''s declared, or from within a derived class in another assembly
	private protected: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (60, 11, N'OOP-Encapsulation
', N'Encapsulation is defined as binding data and code that manipulates it together in a single unit
Data is privately bound within a class without direct access from the outside of the class
All objects that need to read or modify the data of an object should do it through the public methods that a class provides
This characteristic is called data hiding and makes code less error-prone by defining a limited number of entry points to an object’s data', NULL, 1)
INSERT [dbo].[StudyMaterial] ([studyMaterialID], [slotId], [title], [content], [link], [status]) VALUES (61, 11, N'OOP-Inheritance
', N'Inheritance is a mechanism through which a class can inherit the properties and functionalities of another class 
Other classes can inherit these functionalities and data of the parent class as well as extending or modifying them and adding additional functionalities and properties.', NULL, 1)
SET IDENTITY_INSERT [dbo].[StudyMaterial] OFF
GO
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'DBI202', N'Database', N'Introducing database with SQL Server', 1)
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'PRJ301', N'Java Web', N'Java Web with model MVC', 1)
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'PRN211', N'C Sharp Basic', N'Programming cross-flatform', 1)
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'SWP391', N'Mini Capstone', N'You need complete a product with your knowledge', 1)
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'SWR302', N'Software Requirements', N'You learn how to get requrement form customer', 1)
INSERT [dbo].[Subject] ([subjectId], [subjectName], [description], [status]) VALUES (N'SWT301', N'Software Testing', N'You can testing your product with manual and automatic', 1)
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([userId], [username], [email], [password], [birthday], [address], [roleId]) VALUES (1, N'hieuht', N'hieuht@gmail.com', N'1', CAST(N'2008-11-11' AS Date), N'Long An', 2)
INSERT [dbo].[User] ([userId], [username], [email], [password], [birthday], [address], [roleId]) VALUES (2, N'quanntn', N'quanntn@gmail.com', N'1', CAST(N'1998-08-29' AS Date), N'HCM', 2)
INSERT [dbo].[User] ([userId], [username], [email], [password], [birthday], [address], [roleId]) VALUES (3, N'datbh', N'datbh@gmail.com', N'1', CAST(N'2005-07-02' AS Date), N'Vung Tau', 2)
INSERT [dbo].[User] ([userId], [username], [email], [password], [birthday], [address], [roleId]) VALUES (4, N'quocbn', N'quocbn@gmail.com', N'1', CAST(N'1996-01-15' AS Date), N'HCM', 2)
INSERT [dbo].[User] ([userId], [username], [email], [password], [birthday], [address], [roleId]) VALUES (5, N'admin', N'admin@gmail.com', N'1', CAST(N'2023-04-20' AS Date), NULL, 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_Group] FOREIGN KEY([groupID])
REFERENCES [dbo].[Group] ([groupId])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_Group]
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD  CONSTRAINT [FK_Comment_User1] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[Comment] CHECK CONSTRAINT [FK_Comment_User1]
GO
ALTER TABLE [dbo].[Group]  WITH CHECK ADD  CONSTRAINT [FK_Group_Subject] FOREIGN KEY([subjectId])
REFERENCES [dbo].[Subject] ([subjectId])
GO
ALTER TABLE [dbo].[Group] CHECK CONSTRAINT [FK_Group_Subject]
GO
ALTER TABLE [dbo].[Participant]  WITH CHECK ADD  CONSTRAINT [FK_Participant_Group] FOREIGN KEY([groupId])
REFERENCES [dbo].[Group] ([groupId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Participant] CHECK CONSTRAINT [FK_Participant_Group]
GO
ALTER TABLE [dbo].[Participant]  WITH CHECK ADD  CONSTRAINT [FK_Participant_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Participant] CHECK CONSTRAINT [FK_Participant_User]
GO
ALTER TABLE [dbo].[Progress]  WITH CHECK ADD  CONSTRAINT [FK_Progress_Slot] FOREIGN KEY([slotId])
REFERENCES [dbo].[Slot] ([slotId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Progress] CHECK CONSTRAINT [FK_Progress_Slot]
GO
ALTER TABLE [dbo].[Progress]  WITH CHECK ADD  CONSTRAINT [FK_Progress_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Progress] CHECK CONSTRAINT [FK_Progress_User]
GO
ALTER TABLE [dbo].[Slot]  WITH CHECK ADD  CONSTRAINT [FK_Slot_Group] FOREIGN KEY([groupId])
REFERENCES [dbo].[Group] ([groupId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Slot] CHECK CONSTRAINT [FK_Slot_Group]
GO
ALTER TABLE [dbo].[StudyMaterial]  WITH CHECK ADD  CONSTRAINT [FK_StudyMaterial_Slot] FOREIGN KEY([slotId])
REFERENCES [dbo].[Slot] ([slotId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[StudyMaterial] CHECK CONSTRAINT [FK_StudyMaterial_Slot]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([roleId])
REFERENCES [dbo].[Role] ([roleId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [GroupStudy] SET  READ_WRITE 
GO
