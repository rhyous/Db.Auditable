# Db.Auditable

Provides simple auditable values for a database table.

* CreateDate
* LastUpdated
* CreatedBy
* LastUpdatedBy

Look at the last four fields in the table structure below:

```
CREATE TABLE [dbo].[User]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastUpdated] [datetime] NULL,
	[CreatedBy] [int] NOT NULL,
	[LastUpdatedBy] [int] NULL
)
```

It would be unfortunate to have to write code for each entity to separate accommodate these values.

This project adds an abstract AuditableEntity  you can inherit from, so these properties don't have to exist in all entities but can exist in one place.

If you need to use the ColumnAttribute to match the property to a different column name, you can either:
1. Inherit from AuditableEntity and override the virtual members
2. Create your own base class (copy and rename AuditableEntity and add your ColumnAttribute).

## Entity Framework
While the interfaces and AuditableEntity can be used for purposes outside of Entity Framework, other objects are add-ons to Entity Framework. 

AuditableDbContext has been created so most the code to populate the four fields is already written. 

AuditableDbContext does have one abstract method: ```public abstract int GetCurrentUserId();```

As each system has a separate method for getting the UserId, trying to guess at a default method would be foolhardy. So how the DbContext knows the current user id is up to the implementor. You have two options.
1. Leave GetCurrentUserId unimplemented and call SaveChanges with the userid.
2. Implement GetCurrentUserId and call SaveChanges as normal

## Basic Usages Steps
1. Install Rhyous.Db.Auditable from NuGet
2. Have your entities inherit from AuditableEntity
3. Have your DbContext inherit from AuditableDbContext





