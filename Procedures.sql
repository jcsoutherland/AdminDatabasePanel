USE MovieTheaters;

--Report Queries

-- Movies, Tickets, Showings, Average number of Tickets from Last Month 
SELECT Theaters.Movies.MovieName, Theaters.Tickets.GlobalTicketSales, COUNT(Theaters.Showing.ShowTime) AS Showings, (Theaters.Tickets.GlobalTicketSales/COUNT(Theaters.Showing.ShowTime)) AS AverageTicketSales
FROM Theaters.Tickets
	JOIN Theaters.Showing ON Theaters.Tickets.MovieId = Theaters.Showing.MovieId
	JOIN Theaters.Movies ON Theaters.Tickets.MovieId = Theaters.Movies.MovieId
WHERE Theaters.Showing.ShowDate >= '2021-10-01' AND Theaters.Showing.ShowDate <= '2021-10-31'
GROUP BY Theaters.Movies.MovieName, Theaters.Tickets.GlobalTicketSales

-- 10 most popular movies, sales numbers, rank by best seller
SELECT TOP 10 Theaters.Movies.MovieName, Theaters.Tickets.GlobalTicketSales, SUM(CAST(Theaters.Tickets.TicketPrice * Theaters.Tickets.GlobalTicketSales AS BIGINT)) AS MoneyFromTickets
FROM Theaters.Movies
	JOIN Theaters.Tickets ON Theaters.Movies.MovieId = Theaters.Tickets.MovieId
	JOIN Theaters.Showing ON Theaters.Tickets.MovieId = Theaters.Showing.MovieId
WHERE Theaters.Showing.ShowDate >= '2021-01-01' AND Theaters.Showing.ShowDate <= '2021-12-31'
GROUP BY Theaters.Movies.MovieName, Theaters.Tickets.GlobalTicketSales
ORDER BY MoneyFromTickets DESC

--Sales per genre, number of viewers, rank by best seller
SELECT Theaters.Movies.Genre, SUM(CAST(Theaters.Tickets.GlobalTicketSales AS BIGINT)) AS TicketsSold, SUM(CAST(Theaters.Tickets.TicketPrice * Theaters.Tickets.GlobalTicketSales AS BIGINT)) AS Sales
FROM Theaters.Movies
	JOIN Theaters.Tickets ON Theaters.Movies.MovieId = Theaters.Tickets.MovieId
GROUP BY Theaters.Movies.Genre
ORDER BY Sales DESC

--Comedy movies, number of tickets sold, review rating, release date
SELECT Theaters.Movies.MovieName, SUM(CAST(Theaters.Tickets.GlobalTicketSales AS BIGINT)) AS TicketsSold, Theaters.Movies.ReviewRating, Theaters.Movies.ReleaseDate
FROM Theaters.Movies
	JOIN Theaters.Tickets ON Theaters.Tickets.MovieId = Theaters.Movies.MovieId
WHERE Theaters.Movies.Genre = 'Comedy'
GROUP BY Theaters.Movies.MovieName, Theaters.Movies.ReviewRating, Theaters.Movies.ReleaseDate
ORDER BY Theaters.Movies.ReviewRating DESC

--Question Queries
-- Retrieve information for a Theater with ID 30
SELECT Theaters.Theater.Name, Theaters.Theater.Location
FROM Theaters.Theater
WHERE Theaters.Theater.TheaterId = 30
GROUP BY Theaters.Theater.Name, Theaters.Theater.Location

-- Retrieve information for all movies released in 2008
SELECT Theaters.Movies.MovieName, Theaters.Movies.Genre, Theaters.Movies.ReviewRating
FROM Theaters.Movies
WHERE Theaters.Movies.ReleaseDate = '2008'
GROUP BY Theaters.Movies.MovieName, Theaters.Movies.Genre, Theaters.Movies.ReviewRating

-- Display all movies being shown at 7:30 
SELECT Theaters.Movies.MovieName, Theaters.Movies.Genre
FROM Theaters.Movies
	JOIN Theaters.Showing ON Theaters.Showing.MovieId = Theaters.Movies.MovieId
WHERE Theaters.Showing.ShowTime = '7:30'
GROUP BY Theaters.Movies.MovieName, Theaters.Movies.Genre

-- Show Sales information for the movie Twilight: Breaking Dawn
SELECT Theaters.Movies.ReviewRating, Theaters.Tickets.GlobalTicketSales, SUM(CAST(Theaters.Tickets.GlobalTicketSales*Theaters.Tickets.TicketPrice AS BIGINT)) AS Sales
FROM Theaters.Movies
	JOIN Theaters.Tickets ON Theaters.Movies.MovieId = Theaters.Tickets.MovieId
WHERE Theaters.Movies.MovieName = 'Twilight: Breaking Dawn'
GROUP BY Theaters.Movies.ReviewRating, Theaters.Tickets.GlobalTicketSales

-- Show information for a staff member with id 120
SELECT Theaters.Theater.TheaterId, Theaters.Staff.Hours, Theaters.Staff.HourlyPay, (Theaters.Staff.Hours*Theaters.Staff.HourlyPay) AS WeeklyPay
FROM Theaters.Staff
	JOIN Theaters.Theater ON Theaters.Staff.TheaterId = Theaters.Theater.TheaterId
WHERE Theaters.Staff.StaffId = 120
GROUP BY Theaters.Theater.TheaterId, Theaters.Staff.Hours, Theaters.Staff.HourlyPay

-- Show what movies were shown in rooms with attendance 35
SELECT Theaters.Movies.MovieName, Theaters.Showing.ShowDate
FROM Theaters.Movies
	JOIN Theaters.Showing ON Theaters.Showing.MovieId = Theaters.Movies.MovieId
WHERE Theaters.Showing.Attendance = 35
GROUP BY Theaters.Movies.MovieName, Theaters.Showing.ShowDate

-- Show all movies being shown at theater 20
SELECT Theaters.Movies.MovieName, Theaters.Showing.ShowDate
FROM Theaters.Movies
	JOIN Theaters.Showing ON Theaters.Showing.MovieId = Theaters.Movies.MovieId
	JOIN Theaters.Theater ON Theaters.Theater.TheaterId = Theaters.Showing.TheaterId
WHERE Theaters.Theater.TheaterId = 20
GROUP BY Theaters.Movies.MovieName, Theaters.Showing.ShowDate

-- Retrieve staff information for a given theater ID 
SELECT Theaters.Staff.StaffId, Theaters.Staff.HourlyPay
FROM Theaters.Staff
WHERE Theaters.Staff.TheaterId IN (SELECT Theaters.Theater.TheaterId FROM Theaters.Theater WHERE Theaters.Theater.TheaterId = 20)
