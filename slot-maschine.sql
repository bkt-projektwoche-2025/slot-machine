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
    event_id bigint NOT NULL AUTO_INCREMENT,
    uid bigint NOT NULL,
    created_at timestamp DEFAULT now() NOT NULL,
    slot_1 smallint NOT NULL,
    slot_2 smallint NOT NULL,
    slot_3 smallint NOT NULL,
    coins_used bigint NOT NULL,
    coins_recieved bigint DEFAULT '0'::bigint NOT NULL,
    coins bigint DEFAULT '0'::bigint NOT NULL
);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `session`
--

CREATE TABLE session (
    id varchar DEFAULT ''::varchar NOT NULL,
    user_id bigint NOT NULL,
    ip_address varchar NOT NULL,
    created_at timestamp DEFAULT now() NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;


-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `users`
--

CREATE TABLE users (
    id bigint NOT NULL AUTO_INCREMENT,
    name character varying(255) NOT NULL,
    vorname character varying(255) NOT NULL,
    birth_date date NOT NULL,
    email character varying(255) NOT NULL,
    email_verified_at timestamp(0) without timezone,
    password character varying(255) NOT NULL,
    remember_token character varying(100),
    created_at timestamp(0) without timezone,
    updated_at timestamp(0) without timezone,
    guthaben bigint DEFAULT '0'::bigint NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `game`
--
ALTER TABLE game_data
    ADD CONSTRAINT game_data_pkey PRIMARY KEY (event_id);
ALTER TABLE game_data
    ADD CONSTRAINT game_data_uid_fkey FOREIGN KEY (uid) REFERENCES users(id);

--
-- Indizes für die Tabelle `session`
--
ALTER TABLE session
    ADD CONSTRAINT session_pkey PRIMARY KEY (id);
ALTER TABLE session
    ADD CONSTRAINT session_user_id_fkey FOREIGN KEY (user_id) REFERENCES users(id);

--
-- Indizes für die Tabelle `users`
--
ALTER TABLE users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
ALTER TABLE users
ADD CONSTRAINT users_email_unique UNIQUE (email);


/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
