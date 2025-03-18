import styles from './navigation-button.module.css';

interface NavigationButtonProps {
    label: string;
    onClick: () => void;
}

export default function NavigationButton({ label, onClick }: NavigationButtonProps) {
    return (
        <button className={styles['navigate-button']} onClick={onClick}>
            <span>
                {label}
            </span>
        </button>
    );
}