 REQUIREMENTS - GetCount method should be implemented in an optimal way, due to its potential frequent use.

DICTIONARY - Creating a new instance of a dictionary is likely to be more performance heavy than cleaning the dictionary. 
This is because creating a new instance involves memory allocation and initialization,
which can be relatively costly in terms of performance. On the other hand,
cleaning the dictionary typically involves removing existing elements,
which may be a more lightweight operation.
    
ARRAY OF STRINGS - In terms of performance, arrays are usually faster at accessing elements using an index because their elements are stored continuously in memory.


Na podstawie kodu, można wyróżnić następujące klasy i design patterns:
Klasy
MySqlDataBase - klasa reprezentująca bazę danych MySQL.
DataBaseLoggerStrategy - klasa reprezentująca strategię logowania do bazy danych.
FileLoggerStrategy - klasa reprezentująca strategię logowania do pliku.
EventLoggerStrategy - klasa reprezentująca strategię logowania zdarzeń systemowych.
LoggerContext - klasa reprezentująca kontekst logowania, który zarządza strategiami logowania.
