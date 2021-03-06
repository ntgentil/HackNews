PGDMP     :    -                x            hacknews    12.1    12.1                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16393    hacknews    DATABASE     �   CREATE DATABASE hacknews WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Portuguese_Brazil.1252' LC_CTYPE = 'Portuguese_Brazil.1252';
    DROP DATABASE hacknews;
                postgres    false            �            1259    16428 
   Comentario    TABLE     &  CREATE TABLE public."Comentario" (
    "ComentarioId" integer NOT NULL,
    "NoticiaId" integer NOT NULL,
    "Autor" character varying(50) NOT NULL,
    "Titulo" character varying(100) NOT NULL,
    "Mensagem" character varying(200),
    "DataCadastro" timestamp without time zone NOT NULL
);
     DROP TABLE public."Comentario";
       public         heap    postgres    false            �            1259    16396    Noticia    TABLE     c  CREATE TABLE public."Noticia" (
    "NoticiaId" integer NOT NULL,
    "Autor" character varying(50) NOT NULL,
    "Titulo" character varying(100) NOT NULL,
    "SubTitulo" character varying(200),
    "Corpo" text,
    "DataCadastro" timestamp with time zone DEFAULT CURRENT_TIMESTAMP NOT NULL,
    "DataPublicacao" timestamp without time zone NOT NULL
);
    DROP TABLE public."Noticia";
       public         heap    postgres    false            �            1259    16426    comentarios_id_seq    SEQUENCE     �   CREATE SEQUENCE public.comentarios_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.comentarios_id_seq;
       public          postgres    false    205                       0    0    comentarios_id_seq    SEQUENCE OWNED BY     V   ALTER SEQUENCE public.comentarios_id_seq OWNED BY public."Comentario"."ComentarioId";
          public          postgres    false    204            �            1259    16394    noticias_id_seq    SEQUENCE     �   CREATE SEQUENCE public.noticias_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.noticias_id_seq;
       public          postgres    false    203                       0    0    noticias_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.noticias_id_seq OWNED BY public."Noticia"."NoticiaId";
          public          postgres    false    202            �
           2604    16431    Comentario ComentarioId    DEFAULT     }   ALTER TABLE ONLY public."Comentario" ALTER COLUMN "ComentarioId" SET DEFAULT nextval('public.comentarios_id_seq'::regclass);
 J   ALTER TABLE public."Comentario" ALTER COLUMN "ComentarioId" DROP DEFAULT;
       public          postgres    false    204    205    205            �
           2604    16399    Noticia NoticiaId    DEFAULT     t   ALTER TABLE ONLY public."Noticia" ALTER COLUMN "NoticiaId" SET DEFAULT nextval('public.noticias_id_seq'::regclass);
 D   ALTER TABLE public."Noticia" ALTER COLUMN "NoticiaId" DROP DEFAULT;
       public          postgres    false    203    202    203                      0    16428 
   Comentario 
   TABLE DATA           r   COPY public."Comentario" ("ComentarioId", "NoticiaId", "Autor", "Titulo", "Mensagem", "DataCadastro") FROM stdin;
    public          postgres    false    205   .                 0    16396    Noticia 
   TABLE DATA           {   COPY public."Noticia" ("NoticiaId", "Autor", "Titulo", "SubTitulo", "Corpo", "DataCadastro", "DataPublicacao") FROM stdin;
    public          postgres    false    203                     0    0    comentarios_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.comentarios_id_seq', 3, true);
          public          postgres    false    204                       0    0    noticias_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.noticias_id_seq', 6, true);
          public          postgres    false    202            �
           2606    16433    Comentario comentarios_pkey 
   CONSTRAINT     g   ALTER TABLE ONLY public."Comentario"
    ADD CONSTRAINT comentarios_pkey PRIMARY KEY ("ComentarioId");
 G   ALTER TABLE ONLY public."Comentario" DROP CONSTRAINT comentarios_pkey;
       public            postgres    false    205            �
           2606    16404    Noticia noticias_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public."Noticia"
    ADD CONSTRAINT noticias_pkey PRIMARY KEY ("NoticiaId");
 A   ALTER TABLE ONLY public."Noticia" DROP CONSTRAINT noticias_pkey;
       public            postgres    false    203            �
           2606    16434 %   Comentario comentarios_noticiaid_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public."Comentario"
    ADD CONSTRAINT comentarios_noticiaid_fkey FOREIGN KEY ("NoticiaId") REFERENCES public."Noticia"("NoticiaId");
 Q   ALTER TABLE ONLY public."Comentario" DROP CONSTRAINT comentarios_noticiaid_fkey;
       public          postgres    false    203    205    2698               �   x�}��J1���S��!���Ճ�٣��4ba�,M���s̋�{\��@���O�q�E�o1���!0̒8���D1�i�ݰ N{X� �M����T�V�KamN 
s���!���z�}�s����!6�vh�u�T:�i�q��:(\��& �Z�Lˇ@��hoz?�{<xG�]Nݠ^�2�������a�����ٷ�Z��Rn�         3  x��X�n��]���d!-�%Y�g(�噉m)�=�xSMV��!��Ud��U�!?0F�J��[�I�$��*���d� $u�,V�ǹ�ˣ�c�Z[O�}�W���u�!tQ�i��Q5��`�2�
�P՚���WV�ҫ�s��<�㣰Qݨ�7:(����;�pM���^�*�5�`�_�+p{��o��2A-:WX�����8�ܵ���F�6��=jU�~�kZu���㼶���Q��1�Y�:�N9��κV,����'�{0�2T���l�S�h��V�i��˧���eT�,js�#o�6F�X��C�Y�FE�#��8E`#�n��.Z~��/-�Y<�|:�Η�r
;}(p�����K0�Б����"BȐo��?T�iG[��֭	�������`���.�D�q`�)�-]l�/+k�صQM��n�����׆�Sk&R������?��W�;Sg�Um�t��
Al���x��%><��rV��',������7��wp�V�j�"�`O�x�����f� Sy;T/l���?����ېbSV�v>c����po��v��� �3�)���-�4%���d̬��Y0��C�wWX3Uz��U �jY¯zIG�<���p�%)@H�V�p�w@��6-��!�u��t�P��_)��9�̯�z�9���� (]�d��& 6���G/6-Y��Z;�NWG3����W���V7s��*E�8�gDʸ8�B�D 5{�H��9�R.8����k�
�0�m���K�g��?ZW��]t�Kn��i��c�y�tg��u�2+�,'49'~b�p��'��	)�_�l�.�9i }��V6E�{�jH�c��l"��S�J��w+r��,�MHA����`S$� �+��:�dbl���fk��(-H��![K�[���nֶ��^ x�vz�TYWԠn,E���+G���#-��^h��v� }���tP�(��W	?�z+ �+7Z���e	Z=��J5��}8��o%�cNך�g4�\�*�X�F�	�iA�� �k�+��y��K�%���Y�o�#lgja2e�0�Zc�t���q@v�]a�Õ9�=�F�Z��O�n���-�.>?�Ӆk���u(7��uK��i��5.'y/l��� @��vR�.w�A���(i:��� ��dB�<I���2�7��r{`�z3�r"9vb2��a�ߕ���npt�*�����Y=uf���>�E�9s!��F5(��2�g��@zӧv+����A��t^,�u��BC\Լ�y~��&�����f���C�C�?a��Nu�<�+V�!�0E�� ~�Q���"/1T�
���V_�fhʵ<�[��b�&xVX�m776�ʣ&Yk0��e!M-3:���l����t<��(	�ƒV'ǳ�����������Ƀ�Ǉ_���fv|0;���{Ǔ3�묟���3] Q����	,'1Eǒ�¯A�M�ٱ�Z�EJ�R�LtVh���#��[� P�k ���$(*m�|Ԑ��M��_�c4ĵ�- �=�xEUD%cn��҆�8p �����h.�*�!@,�J a9�Ad0&�<�Jw�?��7�mWH6���u� ����������Zm2�����Lm�1uL�LE�4�� T���h�|-� @� _������G��$y4b��#wNeQ�y��F
o4V��
 �>�ݨGe�8�#�3$f�`�+f��5��Xy��PTƘT�
�<(F]�Gz�I
.��FVZ4hݮ���OƼJ|t	:Ã�5F8Wnͅ�ꑐ`��Uh��I]�Q^����P��pԬI�Tgq�n�@4U|"�I������I�Е��MZ$9Ĭ�"<K������bY�. ��f�h��b�����r_�{I3�=`�r�9ͬS��w�N�5��f��G�a�O}��֢�$(�0�1�Ѷ�΢x��f�
�Q����<8m|���rJ*��{'ø�'%�5���kܬ>�~79�1����Dt��+�x��T�	"�f˿�
7�gN�.H��G|Z<�\�l�����a�Yx��S�9�s� � n:�)�5gX���Y�fEJ�$�*��(d������]K��.�,y� l6n��f˦�(�BR��v��������D�3���
�I���/%�h�D6�=��1��/M�+�`V�l-#=�
�ΓZ������pc(���Qב䦉ѕ?I�0�:��&�7�A�3���Q6]�eRWߎ5���c]v`�i�3.�kh'T�[��k��P���i�W�?�%�LO�ĕ.�=x����w�@vo�>I�� CG	A��kط��&�Cp-��r�Nj�=d�&!�٬��u
%FR꣪�&�e+D	{�};�,L[V�O�lB���	��79�kH�A-���U0Q ۗU��lS��'�i����#߾�?���l�w��C��2������Y���!�Ç�q9S��_�8iT���\�0����h�!��_�Y�IS�.�����T>/��Se���"ј����RF=�G������(�.FK�FK8bea����$���\��ӫ�~�����>��94�� �fs�і�[1�Wj���b�E�XpF^��T�h#�����ޔ�G'"ؑ�f�H*�%��+�"������cPq��	��}�$��!�o)���bۧ�.L�I\�%!�L��k�������{f�4þ4��-uV���D�Ӵs|*$Q�Gyy<j(����� �jL�1�J�i3/� ��)��V�O!EBR�[�_����}#G�&D4�/��٦������I�??���߿x�c�+��ý��?J     