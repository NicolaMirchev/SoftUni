INSERT INTO [Equipment] VALUES
('Gri-Gri'),
('Rope'),
('Climbing shoes'),
('Harnesses')

INSERT INTO [Users] VALUES
('Pesho'),
('Gosho'),
('Tosho')

INSERT INTO [Equipment Availability] ([Equipment Type], Holder) VALUES
(2, 2),
(2, 3),
(1, 1)

INSERT INTO [Equipment Availability] ([Equipment Type], Holder) VALUES
(4, 1),
(1, NULL),
(2, NULL),
(3, NULL)

INSERT INTO [Climbing Sessions] VALUES
('Boudler Training', 1, 4)


CREATE VIEW [Session and details] AS
SELECT cs.[Session Name], u.Name AS [Trainer Name], e.NAME AS [Required Equipment] FROM 
[Climbing Sessions] AS cs
JOIN Users AS u ON cs.[Session Trainer] = u.ID
JOIN [Equipment Availability] AS ea ON ea.ID = cs.[Equipment needed]
JOIN [Equipment] as e ON e.ID = ea.[Equipment Type]