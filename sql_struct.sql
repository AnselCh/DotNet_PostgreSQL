-- Table: public.preorder_list

-- DROP TABLE IF EXISTS public.preorder_list;

CREATE TABLE IF NOT EXISTS public.preorder_list
(
    "Id" integer NOT NULL DEFAULT nextval('preorder_list_uid_seq'::regclass),
    createtime timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    "Email" character varying(50) COLLATE pg_catalog."default",
    "Name" character varying(100) COLLATE pg_catalog."default",
    "Phone" character varying(20) COLLATE pg_catalog."default",
    "Contact" text COLLATE pg_catalog."default",
    "Product" text COLLATE pg_catalog."default",
    "Count" integer,
    "Remark" text COLLATE pg_catalog."default",
    "IsCheck" boolean,
    CONSTRAINT preorder_list_pkey PRIMARY KEY ("Id")
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.preorder_list
    OWNER to postgres;