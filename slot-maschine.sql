SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `slot-maschine`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `game`
--

CREATE TABLE game_data (
    event_id serial NOT NULL,
    uid BIGINT NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    slot_1 SMALLINT NOT NULL,
    slot_2 SMALLINT NOT NULL,
    slot_3 SMALLINT NOT NULL,
    coins_used BIGINT NOT NULL,
    coins_recieved BIGINT NOT NULL DEFAULT 0,
    coins BIGINT NOT NULL DEFAULT 0,
    PRIMARY KEY (event_id)
);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `session`
--

CREATE TABLE session (
    id VARCHAR(255) NOT NULL DEFAULT '',
    user_id BIGINT NOT NULL,
    ip_address VARCHAR(16) NOT NULL,
    created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (id)
);


-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `users`
--

CREATE TABLE users (
    id serial NOT NULL,
    name varchar(255) NOT NULL,
    vorname varchar(255) NOT NULL,
    birth_date date NOT NULL,
    email varchar(255) NOT NULL,
    email_verified_at timestamp(0),
    password varchar(255) NOT NULL,
    remember_token varchar(100),
    created_at timestamp(0),
    updated_at timestamp(0),
    guthaben bigint DEFAULT '0' NOT NULL,
    PRIMARY KEY (id)
);

--
-- Indizes für die Tabelle `game`
--
ALTER TABLE game_data
    ADD CONSTRAINT game_data_uid_fkey FOREIGN KEY (uid) REFERENCES users(id);

--
-- Indizes für die Tabelle `session`
--
ALTER TABLE session
    ADD CONSTRAINT session_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);

--
-- Indizes für die Tabelle `users`
--
ALTER TABLE users
ADD CONSTRAINT users_email_unique UNIQUE (email);


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
