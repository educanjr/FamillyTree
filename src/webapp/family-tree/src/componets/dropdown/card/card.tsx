import styles from './card.module.css';

interface CardProps {
    children: React.ReactNode;
}

export default function Card({ children}: CardProps) {
    return <div className={styles['dropdown-card']}>{children}</div>;
}