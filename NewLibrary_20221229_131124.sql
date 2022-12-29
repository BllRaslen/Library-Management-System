--
-- PostgreSQL database dump
--

-- Dumped from database version 12.12
-- Dumped by pg_dump version 15rc2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: public; Type: SCHEMA; Schema: -; Owner: postgres
--

-- *not* creating schema, since initdb creates it


ALTER SCHEMA public OWNER TO postgres;

--
-- Name: auditfunc(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.auditfunc() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
   BEGIN
       INSERT INTO "islemler"("Message" , "islem") VALUES ('Ekleme Basrliyl Bir Sekilde Tamamlandi !' , 'Insert');
      RETURN NEW;
   END;
$$;


ALTER FUNCTION public.auditfunc() OWNER TO postgres;

--
-- Name: deleteani(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.deleteani() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
   BEGIN
      INSERT INTO "birdenAz"("Message" , "islem") VALUES ('silme Basrliyl Bir Sekilde Tamamlandi !' , 'Delete');
      RETURN NEW;
   END;
$$;


ALTER FUNCTION public.deleteani() OWNER TO postgres;

--
-- Name: deletemin(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.deletemin() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
   BEGIN
      INSERT INTO "islemler"("Message" , "islem") VALUES ('silme Basrliyl Bir Sekilde Tamamlandi !' , 'Delete');
      RETURN NEW;
   END;
$$;


ALTER FUNCTION public.deletemin() OWNER TO postgres;

--
-- Name: devletKisaltmasi(text, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public."devletKisaltmasi"(mesaj text, altkaraktersayisi integer, tekrarsayisi integer) RETURNS text
    LANGUAGE plpgsql IMMUTABLE SECURITY DEFINER
    AS $$
DECLARE
    sonuc TEXT; -- Değişken tanımlama bloğu
BEGIN
    sonuc := '';
    
        FOR i IN 1..1 LOOP
            sonuc := sonuc || SUBSTRING(mesaj FROM 1 FOR 2) ;
        END LOOP;
    RETURN sonuc;
END;
$$;


ALTER FUNCTION public."devletKisaltmasi"(mesaj text, altkaraktersayisi integer, tekrarsayisi integer) OWNER TO postgres;

--
-- Name: fiatlarfiltre(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.fiatlarfiltre() RETURNS TABLE(id integer, bookname character varying, fiat money)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY SELECT   "public"."book"."bookID",
         "public"."book"."bookName",
         "public"."price"."price"
FROM     "public"."price" 
RIGHT OUTER JOIN "public"."book" ON "public"."price"."priceID" = "public"."book"."priceID" 
                  ORDER BY  "public"."price"."price" ASC;
END;
$$;


ALTER FUNCTION public.fiatlarfiltre() OWNER TO postgres;

--
-- Name: findlanguage(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.findlanguage(inkey character varying) RETURNS TABLE(bookname character varying, languagename character varying, abb character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY SELECT   "public"."book"."bookName",
         "public"."language"."languageName",
         "public"."language"."languageabb"
FROM     "public"."language" 
RIGHT OUTER JOIN "public"."book"  ON "public"."language"."languageID" = "public"."book"."languageID" 
                 WHERE "public"."language"."languageName" = inkey;
                 END;
$$;


ALTER FUNCTION public.findlanguage(inkey character varying) OWNER TO postgres;

--
-- Name: fun1trigger1(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.fun1trigger1() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    IF NEW."price" <> OLD."price" THEN
        INSERT INTO "fiatveceza"("cezaNo", "eskifiat", "yenifiat", "degisiklikTarihi")
        VALUES(7, OLD."price", NEW."price", CURRENT_TIMESTAMP::TIMESTAMP);
    END IF;

    RETURN NEW;
END;
$$;


ALTER FUNCTION public.fun1trigger1() OWNER TO postgres;

--
-- Name: guncellemeani(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.guncellemeani() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
   BEGIN
      INSERT INTO "birdenAz"("Message" , "islem") VALUES ('Guncelleme Basrliyl Bir Sekilde Tamamlandi !' , 'Update');
      RETURN NEW;
   END;
$$;


ALTER FUNCTION public.guncellemeani() OWNER TO postgres;

--
-- Name: serchwithid(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.serchwithid(iddd integer) RETURNS TABLE(numara integer, adi character varying, soyadi character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY SELECT   "public"."book"."bookID",
         "public"."book"."bookName",
         "public"."book"."authorName"
FROM     "public"."book"
                 WHERE "public"."book"."bookID" = iddd;
END;
$$;


ALTER FUNCTION public.serchwithid(iddd integer) OWNER TO postgres;

--
-- Name: serchwithname(text); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.serchwithname(name_ text) RETURNS TABLE(numara integer, adi character varying, soyadi character varying)
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN QUERY SELECT   "public"."book"."bookID",
         "public"."book"."bookName",
         "public"."book"."authorName"
FROM     "public"."book"
                 WHERE "public"."book"."bookName" = name_;
END;
$$;


ALTER FUNCTION public.serchwithname(name_ text) OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: author; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.author (
    "authorID" integer NOT NULL,
    "authorName" character varying,
    date text,
    "publisherID" integer,
    "publisherID2" integer
);


ALTER TABLE public.author OWNER TO postgres;

--
-- Name: birdenAz; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."birdenAz" (
    "Message" character varying,
    islem character varying
);


ALTER TABLE public."birdenAz" OWNER TO postgres;

--
-- Name: book; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.book (
    "bookID" integer NOT NULL,
    "bookName" character varying(100),
    "authorName" character varying,
    "categoryID" integer,
    "editionID" integer,
    "languageID" integer,
    "placeID" integer,
    "priceID" integer,
    "publisherName" character varying,
    "authorID" integer,
    "publisherID" integer,
    "buyerID" integer,
    "borrowerID" integer
);


ALTER TABLE public.book OWNER TO postgres;

--
-- Name: bookANDcategory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."bookANDcategory" (
    "bookID" integer NOT NULL,
    "categoryID" integer NOT NULL
);


ALTER TABLE public."bookANDcategory" OWNER TO postgres;

--
-- Name: bookANDlanguage; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."bookANDlanguage" (
    "bookID" integer NOT NULL,
    "languageID" integer NOT NULL
);


ALTER TABLE public."bookANDlanguage" OWNER TO postgres;

--
-- Name: bookToEdition; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."bookToEdition" (
    "bookID" integer NOT NULL,
    "editionID" integer NOT NULL
);


ALTER TABLE public."bookToEdition" OWNER TO postgres;

--
-- Name: book_bookID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."book_bookID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."book_bookID_seq" OWNER TO postgres;

--
-- Name: book_bookID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."book_bookID_seq" OWNED BY public.book."bookID";


--
-- Name: borrower; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.borrower (
    "studentID" integer NOT NULL,
    "startDate" date,
    "finishDate" date
);


ALTER TABLE public.borrower OWNER TO postgres;

--
-- Name: borrowerProcess; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."borrowerProcess" (
    "processID" integer NOT NULL,
    "startDate" date NOT NULL,
    "finishDate" date NOT NULL,
    "noteID" integer NOT NULL,
    "borrowerID" integer NOT NULL
);


ALTER TABLE public."borrowerProcess" OWNER TO postgres;

--
-- Name: buyProcess; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."buyProcess" (
    "processID" integer NOT NULL,
    notes text,
    "buyerID" integer NOT NULL,
    "remainingMoney" money NOT NULL
);


ALTER TABLE public."buyProcess" OWNER TO postgres;

--
-- Name: buyProcess_processID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."buyProcess_processID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."buyProcess_processID_seq" OWNER TO postgres;

--
-- Name: buyProcess_processID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."buyProcess_processID_seq" OWNED BY public."buyProcess"."processID";


--
-- Name: buyer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.buyer (
    "studentID" integer NOT NULL,
    "moneyID" integer NOT NULL
);


ALTER TABLE public.buyer OWNER TO postgres;

--
-- Name: category; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.category (
    "categoryID" integer NOT NULL,
    "categoryName" text
);


ALTER TABLE public.category OWNER TO postgres;

--
-- Name: country; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.country (
    "countryID" integer NOT NULL,
    "countryName" character varying NOT NULL,
    countryabb character varying NOT NULL,
    "languageID" integer NOT NULL,
    "publisherID" integer NOT NULL
);


ALTER TABLE public.country OWNER TO postgres;

--
-- Name: edition; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.edition (
    "editionID" integer NOT NULL
);


ALTER TABLE public.edition OWNER TO postgres;

--
-- Name: fiatveceza; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.fiatveceza (
    "cezaNo" integer NOT NULL,
    "degisiklikTarihi" timestamp without time zone NOT NULL,
    yenifiat money NOT NULL,
    eskifiat money NOT NULL
);


ALTER TABLE public.fiatveceza OWNER TO postgres;

--
-- Name: fiatveceza_cezaNo_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."fiatveceza_cezaNo_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."fiatveceza_cezaNo_seq" OWNER TO postgres;

--
-- Name: fiatveceza_cezaNo_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."fiatveceza_cezaNo_seq" OWNED BY public.fiatveceza."cezaNo";


--
-- Name: islemler; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.islemler (
    islemtipi character varying,
    ilemaciklamasi character varying
);


ALTER TABLE public.islemler OWNER TO postgres;

--
-- Name: language; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.language (
    "languageID" integer NOT NULL,
    "languageName" character varying,
    languageabb character varying,
    "countryID" integer
);


ALTER TABLE public.language OWNER TO postgres;

--
-- Name: money; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.money (
    "moneyID" integer NOT NULL,
    money character varying
);


ALTER TABLE public.money OWNER TO postgres;

--
-- Name: notes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.notes (
    "noteID" integer NOT NULL,
    "noteText" text,
    "borrowerID" integer NOT NULL,
    "ProcessID" integer NOT NULL,
    "buyerID" integer NOT NULL
);


ALTER TABLE public.notes OWNER TO postgres;

--
-- Name: notes_noteID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."notes_noteID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."notes_noteID_seq" OWNER TO postgres;

--
-- Name: notes_noteID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."notes_noteID_seq" OWNED BY public.notes."noteID";


--
-- Name: place; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.place (
    "placeID" integer NOT NULL,
    "placeAdress" text
);


ALTER TABLE public.place OWNER TO postgres;

--
-- Name: price; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.price (
    "priceID" integer NOT NULL,
    price money NOT NULL
);


ALTER TABLE public.price OWNER TO postgres;

--
-- Name: price_audits; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.price_audits (
    book_id integer NOT NULL,
    entry_date text NOT NULL
);


ALTER TABLE public.price_audits OWNER TO postgres;

--
-- Name: price_priceID_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."price_priceID_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."price_priceID_seq" OWNER TO postgres;

--
-- Name: price_priceID_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."price_priceID_seq" OWNED BY public.price."priceID";


--
-- Name: publisher; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.publisher (
    "publisherID" integer NOT NULL,
    "publisherName" character varying,
    "publisherAdress" text,
    "publisherMail" character varying,
    "countryID" integer
);


ALTER TABLE public.publisher OWNER TO postgres;

--
-- Name: student; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.student (
    "studentID" integer NOT NULL,
    "buyerID" integer,
    "browwerID" integer,
    "studentName" character varying,
    "studentDate" character varying,
    "StudentPhoneNo" character varying
);


ALTER TABLE public.student OWNER TO postgres;

--
-- Name: book bookID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book ALTER COLUMN "bookID" SET DEFAULT nextval('public."book_bookID_seq"'::regclass);


--
-- Name: buyProcess processID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."buyProcess" ALTER COLUMN "processID" SET DEFAULT nextval('public."buyProcess_processID_seq"'::regclass);


--
-- Name: fiatveceza cezaNo; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fiatveceza ALTER COLUMN "cezaNo" SET DEFAULT nextval('public."fiatveceza_cezaNo_seq"'::regclass);


--
-- Name: notes noteID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notes ALTER COLUMN "noteID" SET DEFAULT nextval('public."notes_noteID_seq"'::regclass);


--
-- Name: price priceID; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.price ALTER COLUMN "priceID" SET DEFAULT nextval('public."price_priceID_seq"'::regclass);


--
-- Data for Name: author; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.author VALUES
	(7, 'Bilal RASLEN', '01.01.2002', NULL, 55),
	(12, 'Bilal RASLEN', '01.01.2002', 5, 4),
	(8, 'avci 32', '01.2.1965', 6, 6),
	(6, 'asdf', '', 55, NULL),
	(9, 'Mustafa', '01.01.2002', NULL, 7),
	(1, 'Muhammed', '01.01.1987', 1, 1),
	(2, 'Ali', '01.01.1987', 2, 2),
	(3, 'Kayhan', '01.01.1987', 3, 3),
	(22, 'aswwww', '22.2.2022', 5, 5),
	(4, 'BLL', '01.01.2002', 1, NULL),
	(5, NULL, NULL, 6, 0),
	(999, 'M.Ali', '01.01.1987', NULL, 999),
	(222, 'Bessam', '01-01-1987', NULL, 222);


--
-- Data for Name: birdenAz; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."birdenAz" VALUES
	('silme Basrliyl Bir Sekilde Tamamlandi !', 'Delete'),
	('silme Basrliyl Bir Sekilde Tamamlandi !', 'Delete'),
	('Ekleme Basrliyl Bir Sekilde Tamamlandi !', 'Insert'),
	('Ekleme Basrliyl Bir Sekilde Tamamlandi !', 'Insert'),
	('Guncelleme Basrliyl Bir Sekilde Tamamlandi !', 'Update'),
	('Guncelleme Basrliyl Bir Sekilde Tamamlandi !', 'Update'),
	('Ekleme Basrliyl Bir Sekilde Tamamlandi !', 'Insert'),
	('Ekleme Basrliyl Bir Sekilde Tamamlandi !', 'Insert'),
	('Guncelleme Basrliyl Bir Sekilde Tamamlandi !', 'Update'),
	('Ekleme Basrliyl Bir Sekilde Tamamlandi !', 'Insert');


--
-- Data for Name: book; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.book VALUES
	(85, NULL, '58', 1, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
	(9, 'ASSAS', NULL, 7, 1, 7, NULL, NULL, NULL, 9, 7, NULL, NULL),
	(5, 'asdfg', NULL, 33, 2, 2, 5, 3, NULL, 2, 2, NULL, NULL),
	(3, 'BName3', 'AName3', 2, 2, 2, 1, 1, '', 3, 1, NULL, NULL),
	(2, 'BName2', 'AName2', 2, 2, 2, 3, 3, '', 2, 3, NULL, NULL),
	(1, 'BookOne', '1', 1, 1, 1, NULL, 9, '', 1, 1, NULL, NULL),
	(4, 'BName4', 'AName4', 2, 1, 1, 5, 3, '', NULL, 2, NULL, NULL),
	(6, 'Altinci Kitap', NULL, 2, 2, 2, NULL, 4, NULL, 2, 2, NULL, NULL),
	(7, 'asd', '1', 1, 2, 1, NULL, 5, '1', 1, 1, NULL, NULL),
	(8, 'sd', NULL, 1, 1, 1, NULL, 6, NULL, 1, 1, NULL, NULL),
	(32, 'BIlal ', '1', 2, 4, 2, NULL, NULL, '1', 1, 1, NULL, NULL),
	(8765, 'CPP Basec', NULL, 999, 2, 999, 3, NULL, NULL, 999, 999, NULL, NULL),
	(222, 'Veri Tabani Yonetim Sistemi', NULL, 999, 1, 222, NULL, NULL, NULL, 222, 222, NULL, NULL);


--
-- Data for Name: bookANDcategory; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: bookANDlanguage; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: bookToEdition; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: borrower; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: borrowerProcess; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: buyProcess; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: buyer; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.buyer VALUES
	(1, 1),
	(2, 2),
	(3, 3),
	(4, 4);


--
-- Data for Name: category; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.category VALUES
	(1, 'web'),
	(2, 'aps'),
	(9, 'web22'),
	(33, 'sssweb'),
	(7, 'VTYS'),
	(999, 'DBMS');


--
-- Data for Name: country; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.country VALUES
	(1, 'Turkey', 'TR', 1, 1),
	(2, 'Suriye', 'SYR', 2, 2);


--
-- Data for Name: edition; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.edition VALUES
	(1),
	(2),
	(3),
	(4);


--
-- Data for Name: fiatveceza; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.fiatveceza VALUES
	(1, '2022-12-22 23:07:11.516484', '$200.00', '$201.00'),
	(2, '2022-12-22 23:08:47.332178', '$899.00', '$88.00'),
	(9, '2022-12-23 01:02:59.9245', '$9.00', '$0.00'),
	(7, '2022-12-23 01:44:48.427017', '$77.00', '$0.00');


--
-- Data for Name: islemler; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: language; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.language VALUES
	(1, 'turkce', 'tr', 1),
	(2, 'Arapca', 'ar', 2),
	(4, 'rusca', 'rc', 1),
	(3, 'Franch', 'FR', 2),
	(5, 'Farisca', 'FR', NULL),
	(9, 'ARABCA', 'ARB', NULL),
	(47, 'Arapca', 'Arapca', 5),
	(7, 'almaniyye', 'al', 8),
	(999, 'c++', 'cpp', NULL),
	(12, 'asd', 'aa', NULL),
	(222, 'ARAPCA', 'AR', NULL);


--
-- Data for Name: money; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.money VALUES
	(1, '22');


--
-- Data for Name: notes; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.notes VALUES
	(1, 'Makale, herhangi bir konuda, bir görüşü, bir düşünceyi savunmak ve kanıtlamak için yazılan yazılara denir.', 1, 1, 1),
	(2, 'Gazete ve dergilerde yayımlanır.', 2, 2, 2),
	(3, 'ilerde yayımlanır.', 3, 3, 3),
	(4, 'we cant googing to cahannam', 4, 4, 4);


--
-- Data for Name: place; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.place VALUES
	(3, '33:2022:B22:B.Blok'),
	(1, '33:2022:A22:A.Blok'),
	(5, '33:2022:B22:B.Blok');


--
-- Data for Name: price; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.price VALUES
	(1, '$55.00'),
	(3, '$37.00'),
	(2, '$123.00'),
	(4, '$34.00'),
	(5, '$43.00'),
	(6, '$344.00'),
	(7, '$54.00'),
	(8, '$66.00'),
	(9, '$56.00'),
	(11, '$200.00'),
	(10, '$899.00'),
	(58, '$9.00'),
	(57, '$88.00'),
	(85, '$0.00'),
	(14, '$77.00');


--
-- Data for Name: price_audits; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.price_audits VALUES
	(5, '20.2.2002');


--
-- Data for Name: publisher; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.publisher VALUES
	(6, 'dar alshifa', '507 - 20th Ave. E.\nApt. 2A', 'islamicdarilnesir@gmail.com', 2),
	(9, 'ALi', 'SYR 2012', 'ajsj@gmail.com', NULL),
	(11, 'dd', 'd', 'd', NULL),
	(8, 'sdsdsd', 'sdsddsdssd', 'sssdsddsds', NULL),
	(4, 'dar nesir', '507 - 20th Ave. E.\nApt. 2A', 'muaaznesriyet@gmail.com', NULL),
	(3, 'islamic darilnesir', '507 - 20th Ave. E.\nApt. 2A', 'islamicdarilnesir@gmail.com', 2),
	(2, 'muaaz nesriyet', '722 Moss Bay Blvd.', 'muaaznesriyet@gmail.com', 1),
	(99, 'we', 'we', 'cxwewe#ogr.tr', NULL),
	(7, 'dar alez ', '507 - 20th Ave. E.\nApt. 2A', 'muaaznesriyet@gmail.com', NULL),
	(1, 'dar Publisher', 'Edgeham Hollow\nWinchester Way', 'darPublisher@edu.com', 1),
	(999, 'Yayin Evi', '722 Moss Bay Blvd.', 'muaaznesriyet55@gmail.com', NULL),
	(222, 'yayın Evı', '507 - 20th Ave. E.\nApt. 2A', '222''gmaılçcom', NULL);


--
-- Data for Name: student; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.student VALUES
	(1, 1, 1, 'BLL', '1.2.1344', '+905383471275'),
	(2, 3, 2, 'ALL', '23.4.1876', '+905383471275'),
	(3, 4, 3, 'ML', '01.3.1976', '+905383471275'),
	(4, 5, 4, 'halit', 'ayse', '+905383471275'),
	(6, 7, 6, 'ulker', '2.2.2002', '+905383471275'),
	(5, 6, 5, 'mustafa', '1.1.2001', '+905383471275');


--
-- Name: book_bookID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."book_bookID_seq"', 26, true);


--
-- Name: buyProcess_processID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."buyProcess_processID_seq"', 1, false);


--
-- Name: fiatveceza_cezaNo_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."fiatveceza_cezaNo_seq"', 1, false);


--
-- Name: notes_noteID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."notes_noteID_seq"', 1, false);


--
-- Name: price_priceID_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public."price_priceID_seq"', 2, true);


--
-- Name: fiatveceza PK; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.fiatveceza
    ADD CONSTRAINT "PK" PRIMARY KEY ("cezaNo");


--
-- Name: bookANDcategory bookANDcategory_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."bookANDcategory"
    ADD CONSTRAINT "bookANDcategory_pkey" PRIMARY KEY ("bookID");


--
-- Name: bookANDlanguage bookANDlanguage_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."bookANDlanguage"
    ADD CONSTRAINT "bookANDlanguage_pkey" PRIMARY KEY ("languageID", "bookID");


--
-- Name: bookToEdition bookToEdition_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."bookToEdition"
    ADD CONSTRAINT "bookToEdition_pkey" PRIMARY KEY ("bookID", "editionID");


--
-- Name: borrowerProcess borrowerProcess_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."borrowerProcess"
    ADD CONSTRAINT "borrowerProcess_pkey" PRIMARY KEY ("processID");


--
-- Name: edition edition_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.edition
    ADD CONSTRAINT edition_pkey PRIMARY KEY ("editionID");


--
-- Name: publisher publisher_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.publisher
    ADD CONSTRAINT publisher_pkey PRIMARY KEY ("publisherID");


--
-- Name: student student_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.student
    ADD CONSTRAINT student_pkey PRIMARY KEY ("studentID");


--
-- Name: author unique_author_authorID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.author
    ADD CONSTRAINT "unique_author_authorID" PRIMARY KEY ("authorID");


--
-- Name: author unique_author_pubID2; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.author
    ADD CONSTRAINT "unique_author_pubID2" UNIQUE ("publisherID2");


--
-- Name: bookANDcategory unique_bookANDcategory_bookID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."bookANDcategory"
    ADD CONSTRAINT "unique_bookANDcategory_bookID" UNIQUE ("bookID");


--
-- Name: bookANDlanguage unique_bookANDlanguage_bookID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."bookANDlanguage"
    ADD CONSTRAINT "unique_bookANDlanguage_bookID" UNIQUE ("bookID");


--
-- Name: bookANDlanguage unique_bookANDlanguage_languageID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."bookANDlanguage"
    ADD CONSTRAINT "unique_bookANDlanguage_languageID" UNIQUE ("languageID");


--
-- Name: bookToEdition unique_bookToEdition_bookID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."bookToEdition"
    ADD CONSTRAINT "unique_bookToEdition_bookID" UNIQUE ("bookID");


--
-- Name: bookToEdition unique_bookToEdition_editionID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."bookToEdition"
    ADD CONSTRAINT "unique_bookToEdition_editionID" UNIQUE ("editionID");


--
-- Name: book unique_book_bookID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT "unique_book_bookID" PRIMARY KEY ("bookID");


--
-- Name: borrowerProcess unique_borrowerProcess_borrowerID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."borrowerProcess"
    ADD CONSTRAINT "unique_borrowerProcess_borrowerID" UNIQUE ("borrowerID");


--
-- Name: borrowerProcess unique_borrowerProcess_noteID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."borrowerProcess"
    ADD CONSTRAINT "unique_borrowerProcess_noteID" UNIQUE ("noteID");


--
-- Name: borrower unique_borrower_borrowerID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.borrower
    ADD CONSTRAINT "unique_borrower_borrowerID" PRIMARY KEY ("studentID");


--
-- Name: buyProcess unique_buyProcess_buyerID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."buyProcess"
    ADD CONSTRAINT "unique_buyProcess_buyerID" UNIQUE ("buyerID");


--
-- Name: buyProcess unique_buyProcess_processID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."buyProcess"
    ADD CONSTRAINT "unique_buyProcess_processID" PRIMARY KEY ("processID");


--
-- Name: buyer unique_buyer_buyerID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.buyer
    ADD CONSTRAINT "unique_buyer_buyerID" PRIMARY KEY ("studentID");


--
-- Name: buyer unique_buyer_moneyID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.buyer
    ADD CONSTRAINT "unique_buyer_moneyID" UNIQUE ("moneyID");


--
-- Name: category unique_category_categoryID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.category
    ADD CONSTRAINT "unique_category_categoryID" PRIMARY KEY ("categoryID");


--
-- Name: country unique_country_countryID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.country
    ADD CONSTRAINT "unique_country_countryID" PRIMARY KEY ("countryID");


--
-- Name: country unique_country_languageID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.country
    ADD CONSTRAINT "unique_country_languageID" UNIQUE ("languageID");


--
-- Name: country unique_country_publisherID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.country
    ADD CONSTRAINT "unique_country_publisherID" UNIQUE ("publisherID");


--
-- Name: edition unique_edition_editionID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.edition
    ADD CONSTRAINT "unique_edition_editionID" UNIQUE ("editionID");


--
-- Name: language unique_language_languageID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.language
    ADD CONSTRAINT "unique_language_languageID" PRIMARY KEY ("languageID");


--
-- Name: money unique_money_moneyID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.money
    ADD CONSTRAINT "unique_money_moneyID" PRIMARY KEY ("moneyID");


--
-- Name: notes unique_notes_borrowerID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notes
    ADD CONSTRAINT "unique_notes_borrowerID" UNIQUE ("borrowerID");


--
-- Name: notes unique_notes_buyerID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notes
    ADD CONSTRAINT "unique_notes_buyerID" UNIQUE ("buyerID");


--
-- Name: notes unique_notes_buyerProcess; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notes
    ADD CONSTRAINT "unique_notes_buyerProcess" UNIQUE ("ProcessID");


--
-- Name: notes unique_notes_noteNo; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.notes
    ADD CONSTRAINT "unique_notes_noteNo" PRIMARY KEY ("noteID");


--
-- Name: place unique_place_placeID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.place
    ADD CONSTRAINT "unique_place_placeID" PRIMARY KEY ("placeID");


--
-- Name: price unique_price_priceID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.price
    ADD CONSTRAINT "unique_price_priceID" PRIMARY KEY ("priceID");


--
-- Name: student unique_student_studentID; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.student
    ADD CONSTRAINT "unique_student_studentID" UNIQUE ("studentID");


--
-- Name: index_bookID; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "index_bookID" ON public."bookToEdition" USING btree ("bookID");


--
-- Name: index_categoryID; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "index_categoryID" ON public."bookANDcategory" USING btree ("categoryID");


--
-- Name: index_countryID; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "index_countryID" ON public.language USING btree ("countryID");


--
-- Name: index_countryID1; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "index_countryID1" ON public.publisher USING btree ("countryID");


--
-- Name: index_languageID; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "index_languageID" ON public."bookANDlanguage" USING btree ("languageID");


--
-- Name: book deleteanitrigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER deleteanitrigger AFTER DELETE ON public.book FOR EACH ROW EXECUTE FUNCTION public.deleteani();


--
-- Name: book guncellemeanitrigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER guncellemeanitrigger AFTER UPDATE ON public.book FOR EACH ROW EXECUTE FUNCTION public.guncellemeani();


--
-- Name: book price_trigger; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER price_trigger AFTER INSERT ON public.book FOR EACH ROW EXECUTE FUNCTION public.auditfunc();


--
-- Name: price trgger_1; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER trgger_1 BEFORE UPDATE ON public.price FOR EACH ROW EXECUTE FUNCTION public.fun1trigger1();


--
-- Name: book author_with_book; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT author_with_book FOREIGN KEY ("authorID") REFERENCES public.author("authorID") MATCH FULL;


--
-- Name: bookANDcategory book_with_bookANDcategory; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."bookANDcategory"
    ADD CONSTRAINT "book_with_bookANDcategory" FOREIGN KEY ("bookID") REFERENCES public.book("bookID") MATCH FULL;


--
-- Name: book book_with_publisher; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT book_with_publisher FOREIGN KEY ("publisherID") REFERENCES public.publisher("publisherID") MATCH FULL;


--
-- Name: book borrower_with_book; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT borrower_with_book FOREIGN KEY ("borrowerID") REFERENCES public.borrower("studentID") MATCH FULL;


--
-- Name: book buyer_with_book; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT buyer_with_book FOREIGN KEY ("buyerID") REFERENCES public.buyer("studentID") MATCH FULL;


--
-- Name: book category_with_book; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT category_with_book FOREIGN KEY ("categoryID") REFERENCES public.category("categoryID") MATCH FULL;


--
-- Name: bookANDcategory category_with_bookANDcategory; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."bookANDcategory"
    ADD CONSTRAINT "category_with_bookANDcategory" FOREIGN KEY ("categoryID") REFERENCES public.category("categoryID") MATCH FULL;


--
-- Name: publisher country_with_poblisher; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.publisher
    ADD CONSTRAINT country_with_poblisher FOREIGN KEY ("countryID") REFERENCES public.country("countryID") MATCH FULL;


--
-- Name: book editon_with_book; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT editon_with_book FOREIGN KEY ("editionID") REFERENCES public.edition("editionID") MATCH FULL;


--
-- Name: book language_with_book; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT language_with_book FOREIGN KEY ("languageID") REFERENCES public.language("languageID") MATCH FULL;


--
-- Name: country language_with_country; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.country
    ADD CONSTRAINT language_with_country FOREIGN KEY ("languageID") REFERENCES public.language("languageID") MATCH FULL;


--
-- Name: borrower note_with_borrower; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.borrower
    ADD CONSTRAINT note_with_borrower FOREIGN KEY ("studentID") REFERENCES public.notes("borrowerID") MATCH FULL;


--
-- Name: buyer note_with_buyer; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.buyer
    ADD CONSTRAINT note_with_buyer FOREIGN KEY ("studentID") REFERENCES public.notes("buyerID") MATCH FULL;


--
-- Name: book place_with_book; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT place_with_book FOREIGN KEY ("placeID") REFERENCES public.place("placeID") MATCH FULL;


--
-- Name: book price_with_book; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT price_with_book FOREIGN KEY ("priceID") REFERENCES public.price("priceID") MATCH FULL;


--
-- Name: borrower student_with_browwer; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.borrower
    ADD CONSTRAINT student_with_browwer FOREIGN KEY ("studentID") REFERENCES public.student("studentID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: buyer student_with_buyer; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.buyer
    ADD CONSTRAINT student_with_buyer FOREIGN KEY ("studentID") REFERENCES public.student("studentID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: SCHEMA public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE USAGE ON SCHEMA public FROM PUBLIC;
GRANT ALL ON SCHEMA public TO PUBLIC;


--
-- PostgreSQL database dump complete
--

