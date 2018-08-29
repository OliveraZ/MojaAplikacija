INSERT INTO Clanovi
VALUES
('Milan Radovanović', 'milan@gmil.com', 1, 'MilanR', 'milan1234'),
('Stana Milošević', 'stana@gmail.com', 1, 'Stana', 's12')

INSERT INTO Sednice
VALUES
(2, '20180605', 'Vanredna', 'RAF15', 'zapisnik2', 1)

INSERT INTO Prisustvo
VALUES

(0, null, 2, 2)

INSERT INTO VrstaDokumenta
VALUES
('Doktorat'),
('Magistratura')



INSERT INTO Prilozi
(ID_Sednice, ID_Dokumenta, Putanja, Poslato, DatumSlanja)
VALUES
(1, 1, 'c:\\putanja', 1, '20180506' ),
(2, 2, 'c:\\putanja2', 1, '20180505')


SELECT * FROM Prilozi
GO