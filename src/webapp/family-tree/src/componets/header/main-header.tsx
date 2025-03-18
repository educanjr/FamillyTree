import Link from "next/link";
import Image from "next/image";

import styles from './main-header.module.css'

import logo from '@/assets/images/logo.png';

export default function MainHeader() {
    return (
        <header className={styles['header']}>
            <Link href={"/"} className={styles['logo']}>
                <Image src={logo} alt="Logo" />
                FamilyTree
            </Link>
        </header>
    )
}