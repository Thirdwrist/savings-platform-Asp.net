CREATE TABLE users(
	id int unsigned auto_increment,
    phone varchar(20),
    username varchar(20) not null,
    bvn char(20),
    password varchar(255) not null,
    profile_avatar varchar(300),
    created_at timestamp not null default current_timestamp,
    updated_at timestamp not null default current_timestamp,

    PRIMARY KEY (id)

);

CREATE TABLE wallets(
	id int unsigned auto_increment not null,
    balance bigint not null,
    user_id int unsigned not null,
    created_at timestamp not null default CURRENT_TIMESTAMP,
	updated_at timestamp not null default CURRENT_TIMESTAMP,
    currency char(20) not null,
    wallet_type char(20) not null,
    hold boolean not null default true,

    PRIMARY KEY (id),
    FOREIGN KEY (user_id) REFERENCES users(id)

);


CREATE TABLE wallet_holds(
	id int unsigned auto_increment not null,
    user_id int unsigned not null,
    wallet_id int unsigned not null,
    release_day date not null,
    created_at timestamp not null default CURRENT_TIMESTAMP,
    updated_at timestamp not null default CURRENT_TIMESTAMP,

    primary key (id),
    foreign key (user_id) references users(id),
    foreign key (wallet_id) references wallets(id)
);

CREATE TABLE wallet_funds(

	id int unsigned auto_increment not null,
    user_id int unsigned not null,
    wallet_id int unsigned not null,
    amount bigint not null,
    currency char(20) not null default 'NGN',
    method char(100) not null,
    txn_token char(199) not null,
    reference char(199) not null,
    created_at timestamp not null default CURRENT_TIMESTAMP,
    updated_at timestamp not null default CURRENT_TIMESTAMP,

    primary key (id),
    foreign key (user_id) references users(id),
    foreign key (wallet_id) references wallets(id)
);


CREATE TABLE wallet_policies(

	id int unsigned auto_increment not null,
    name text not null,
    description text,
    release_interval enum("DAY", "WEEK", "MONTH", "YEAR"),
    release_interval_count int,
    release_count_per_year int,
    can_release_on_non_release_day boolean,
    release_on_non_release_day_penalty int,
    interest int not null,
    hold boolean not null,
    can_break_hold boolean,
    hold_break_penalty int,
    currency char(20) not null,
    icon_image char(200),
    banner char(200),
    created_at timestamp not null default CURRENT_TIMESTAMP,
    updated_at timestamp not null default CURRENT_TIMESTAMP,

    primary key (id)

);

CREATE TABLE banks(
	id int unsigned auto_increment not null,
    name text not null,
    code int unsigned not null,
    nibss_code int unsigned not null,
    status boolean not null,
    created_at timestamp not null default CURRENT_TIMESTAMP,
    updated_at timestamp not null default CURRENT_TIMESTAMP,

    primary key (id)
);

CREATE TABLE user_bank_accounts(
	id int unsigned auto_increment not null,
    bank_id int unsigned not null,
    user_id int unsigned not null,
    account_name text not null,
    account_number char(25) not null,
    created_at timestamp not null default CURRENT_TIMESTAMP,
    updated_at timestamp not null default CURRENT_TIMESTAMP,

    primary key (id),
    foreign key (user_id) references users(id),
    foreign key (bank_id) references banks(id)
);

CREATE TABLE transactions(
	id int unsigned auto_increment not null,
    user_id int unsigned not null,
    wallet_id int unsigned not null,
    current_balance bigint not null,
    initial_balance bigint not null,
    currency char(20) not null default 'NGN',
    transaction_type enum("DEBIT", "CREDIT") not null,
    status char(20) not null,
    model_type varchar(1000) not null,
	model_id int unsigned not null,
    created_at timestamp not null default CURRENT_TIMESTAMP,
    updated_at timestamp not null default CURRENT_TIMESTAMP,


    primary key (id),
    foreign key (user_id) references users(id),
    foreign key (wallet_id) references wallets(id)
);

CREATE TABLE transfers(
	id int unsigned auto_increment not null,
    user_id int unsigned not null,
    wallet_id int unsigned not null,
    amount bigint not null,
    user_bank_account_id int unsigned not null,
    bank_id int  unsigned not null,
    currency char(20) not null default 'NGN',
    status char(20) not null,
    created_at timestamp not null default CURRENT_TIMESTAMP,
    updated_at timestamp not null default CURRENT_TIMESTAMP,

    primary key (id),
	foreign key (user_id) references users(id),
	foreign key (wallet_id) references wallets(id),
	foreign key (bank_id) references banks(id),
	foreign key (user_bank_account_id) references user_bank_accounts(id)
);




